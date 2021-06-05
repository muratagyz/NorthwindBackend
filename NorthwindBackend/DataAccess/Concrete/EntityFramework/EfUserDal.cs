using Core.DataAccess.EntityFramework;
using System.Linq;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, NorthwindContext>, IUserDal
    {
        public List<OpertaionClaim> GetClaims(User user)
        {
            using (var context = new NorthwindContext())
            {
                var result = from opertaionClaim in context.OpertaionClaims 
                             join UserOpertaionClaim in context.UserOpertaionClaims
                             on opertaionClaim.Id equals UserOpertaionClaim.OpertaionClaimId
                             where UserOpertaionClaim.UserId == user.Id
                             select new OpertaionClaim { Id = opertaionClaim.Id, Name = opertaionClaim.Name };
                return result.ToList();
            }
        }
    }
}
