using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDonateImageDal:EfEntityRepositoryBase<DonateImage,WhitelistApplicationContext>,IDonateImageDal
    {
    }
}
