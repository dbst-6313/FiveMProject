using Core.Utilities.Results;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IFivemUserService
    {
        IResult Update(FivemUser fivemUser);
        IResult Delete(FivemUser fivemUser);
        IDataResult<List<FivemUser>> GetAll();
        //IDataResult<FivemUser> GetById(int identifier);
      
    }
}
