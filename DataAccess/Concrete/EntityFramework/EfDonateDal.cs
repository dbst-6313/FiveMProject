using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entity.Concrete;
using Entity.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDonateDal:EfEntityRepositoryBase<Donate, WhitelistApplicationContext>,IDonateDal
    {

        public List<DonateDetailDto> GetDonateDetails(Expression<Func<Donate, bool>> filter = null)
        {
            using (WhitelistApplicationContext context = new WhitelistApplicationContext())
            {
                var result =
                             from donate in filter == null ? context.donates : context.donates.Where(filter)



                             select new DonateDetailDto
                             {
                                 DonateId = donate.DonateId,
                                 DonateName = donate.DonateName,
                                 Price = donate.Price,
                                 UsageTime = donate.UsageTime,
                                 Description = donate.Description,
                                 Images = (from i in context.donateimages where i.DonateId == donate.DonateId select i.ImagePath).ToList(),
                             };

                return result.ToList();


            }
        }
    }
}
