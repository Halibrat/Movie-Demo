using Core.DataAccess;
using Core.Entities.Concrete;
using MovieProject.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieProject.DataAccess.Abstract
{
   public interface IUserDal:IEntityRepository<Core.Entities.Concrete.User>
    {
        List<OperationClaim> GetClaims(Core.Entities.Concrete.User user);
    }
}
