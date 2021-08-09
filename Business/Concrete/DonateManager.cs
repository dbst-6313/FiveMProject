using Business.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class DonateManager : IDonateService
    {
        IDonateDal _donateDal;

        public DonateManager(IDonateDal donateDal)
        {
            _donateDal = donateDal;
        }

        public IResult Add(Donate donate)
        {
            _donateDal.Add(donate);
            return new SuccessResult(Messages.DonateAdded);
        }

        public IResult Delete(Donate donate)
        {
            _donateDal.Delete(donate);
            return new SuccessResult(Messages.DonateDeleted);
        }

        public IDataResult<List<Donate>> GetAll()
        {
            return new SuccessDataResult<List<Donate>>(_donateDal.GetAll(), Messages.DonateListed);
        }

        public IDataResult<Donate> GetById(int id)
        {
            return new SuccessDataResult<Donate>(_donateDal.Get(d => d.DonateId == id));
        }

        public IDataResult<List<DonateDetailDto>> GetDonateDetails()
        {
            return new SuccessDataResult<List<DonateDetailDto>>(_donateDal.GetDonateDetails());
        }

        public IResult Update(Donate donate)
        {
            _donateDal.Update(donate);
            return new SuccessResult(Messages.DonateUpdated);
        }
    }
}
