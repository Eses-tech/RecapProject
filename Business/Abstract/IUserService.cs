using Core.Entity.Concrete;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService:IEntityService<User>
    {
        IDataResult<List<OperationClaim>> GetClaims(User user);
        
        IDataResult<User> GetByMail(string email);
    }
}
