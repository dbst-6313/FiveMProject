using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Text;

namespace DataAccess.Concrete.Entityframework
{
    public class WhitelistApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=127.0.0.1;port=3306;database=whitelistapplication;uid=root;");
        }
        public DbSet<Answer> answers{ get; set; }
        public DbSet<Question> questions { get; set; }
        public DbSet<State> state { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<OperationClaim> operation_claims { get; set; }
        public DbSet<UserOperationClaim> user_operation_claims { get; set; }
        public DbSet<Donate> donates { get; set; }
        public DbSet<DonateImage> donateimages { get; set; }

    }
}