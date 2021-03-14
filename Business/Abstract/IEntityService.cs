using Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IEntityService<T> where T:class,IEntity,new()
    {
        List<T> GetAll();
        T GetById(int id);
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
