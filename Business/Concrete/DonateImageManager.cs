using Business.Abstract;
using Core.Utilities.Business;
using Core.Utilities.Constants;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class DonateImageManager : IDonateImageService
    {
        IDonateImageDal _donateImageDal;

        public DonateImageManager(IDonateImageDal donateImageDal)
        {
            _donateImageDal = donateImageDal;
        }

        public IResult Add(IFormFile file, DonateImage donateImage)
        {
            var imageLımıt = _donateImageDal.GetAll(d => d.DonateId == donateImage.DonateId).Count;
            if (imageLımıt>6)
            {
                return new ErrorResult(Messages.DonateImageLimit);
            }
            var donateImageResult = FileHelper.Upload(file);
            if (!donateImageResult.Success)
            {
                return new ErrorResult(donateImageResult.Message);
            }
            donateImage.ImagePath = donateImageResult.Message;
            donateImage.Date = DateTime.Now;
            _donateImageDal.Add(donateImage);
            return new SuccessResult(Messages.DonateImageAdded);

        }

        public IResult Delete(DonateImage donateImage)
        {
            var image = _donateImageDal.Get(d => d.Id == donateImage.Id);
            if (image == null)
            {
                return new ErrorResult(Messages.DonateImageNotFound);
            }
            FileHelper.Delete(image.ImagePath);
            _donateImageDal.Delete(donateImage);
            return new SuccessResult(Messages.DonateImageDeleted);
        }

        public IDataResult<List<DonateImage>> GetAll()
        {
            return new SuccessDataResult<List<DonateImage>>(_donateImageDal.GetAll());
        }

        public IDataResult<DonateImage> GetById(int Id)
        {
            return new SuccessDataResult<DonateImage>(_donateImageDal.Get(d => d.DonateId == Id));
        }

        public IDataResult<List<DonateImage>> GetImagesByDonateId(int donateId)
        {
            IResult result = BusinessRules.Run(DonateImageCheck(donateId));
            if (result != null)
            {
                return new ErrorDataResult<List<DonateImage>>(result.Message);
            }
            return new SuccessDataResult<List<DonateImage>>(DonateImageCheck(donateId).Data);
        }

        public IResult Update(IFormFile file, DonateImage donateImage)
        {
            var image = _donateImageDal.Get(d => d.Id == donateImage.Id);
            if (image == null)
            {
                return new ErrorResult(Messages.CarImageNotFound);
            }
            var updated = FileHelper.Update(file, image.ImagePath);
            if (!updated.Success)
            {
                return new ErrorResult(updated.Message);
            }
            donateImage.ImagePath = updated.Message;
            _donateImageDal.Update(donateImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        private IDataResult<List<DonateImage>> DonateImageCheck(int donateId)
        {
            try
            {
                string path = @"\images\logo.jpg";
                var result = _donateImageDal.GetAll(d => d.DonateId == donateId).Any();
                if (!result)
                {
                    List<DonateImage> carimage = new List<DonateImage>();
                    carimage.Add(new DonateImage { DonateId = donateId, ImagePath = path, Date = DateTime.Now });
                    return new SuccessDataResult<List<DonateImage>>(carimage);
                }
            }
            catch (Exception exception)
            {

                return new ErrorDataResult<List<DonateImage>>(exception.Message);
            }

            return new SuccessDataResult<List<DonateImage>>(_donateImageDal.GetAll(d => d.DonateId == donateId).ToList());
        }
    }
}




