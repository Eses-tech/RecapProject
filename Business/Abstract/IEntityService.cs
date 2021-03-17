using Core;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<B> where B:class,IEntity,new()
    {
        IDataResult<List<B>> GetAll();
        IDataResult<B> GetById(int id);
        IResult Add(B entity);
        IResult Delete(B entity);
        IResult Update(B entity);
    }
}
