using Core.DataAccess.EntityFramework;
using Core.Entities.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Entityframework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DataAccess.Concrete.EntityFramework
{
   public  class EfUserDal : EfEntityRepositoryBase<User, WhitelistApplicationContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new WhitelistApplicationContext())
            {
                var result = from operationClaim in context.operation_claims
                             join userOperationClaim in context.user_operation_claims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
                return result.ToList();

            }
        }
    }
}
