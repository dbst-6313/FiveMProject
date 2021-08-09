using Core.Utilities.Results;
using Entity.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDonateImageService
    {

        IDataResult<List<DonateImage>> GetAll();
        IDataResult<List<DonateImage>> GetImagesByDonateId(int donateId);
        IDataResult<DonateImage> GetById(int Id);
        IResult Add(IFormFile file, DonateImage donateImage);
        IResult Update(IFormFile file, DonateImage donateImage);
        IResult Delete(DonateImage donateImage);
    }
}
