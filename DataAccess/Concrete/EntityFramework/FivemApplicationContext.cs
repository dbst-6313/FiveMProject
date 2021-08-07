using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class FivemApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=essentialmodeana;uid=root;");
        }
        public DbSet<FivemUser> users { get; set; }
     
    }
}