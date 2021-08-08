using Business.Abstract;
using Core.Utilities.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class FivemUserManager : IFivemUserService
    {

        IFivemUserDal _fivemUserDal;

        public FivemUserManager(IFivemUserDal fivemUserDal)
        {
            _fivemUserDal= fivemUserDal;
        }

        public IResult Delete(FivemUser fivemUser)
        {
            _fivemUserDal.Delete(fivemUser);
            return new SuccessResult();
        }

        public IDataResult<List<FivemUser>> GetAll()
        {
            return new SuccessDataResult<List<FivemUser>>(_fivemUserDal.GetAll(),Messages.FivemUserListed);
        }

        public IDataResult<FivemUser> GetById(string identifier)
        {
            return new SuccessDataResult<FivemUser>(_fivemUserDal.Get(f => f.identifier == identifier));
        }

        public IResult Update(FivemUser fivemUser)
        {
            _fivemUserDal.Update(fivemUser);
            return new SuccessResult();
        }
    }
}
