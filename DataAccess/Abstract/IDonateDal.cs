using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IDonateDal:IEntityRepository<Donate>
    {
        List<DonateDetailDto> GetDonateDetails(Expression<Func<Donate, bool>> filter = null);

    }
}
