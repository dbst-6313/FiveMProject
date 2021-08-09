using Core.Utilities.Results;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IDonateService
    {
        IDataResult<List<Donate>> GetAll();
        IDataResult<Donate> GetById(int id);
        IResult Add(Donate donate);
        IResult Delete(Donate donate);
        IResult Update(Donate donate);
        IDataResult<List<DonateDetailDto>> GetDonateDetails();


    }
}
