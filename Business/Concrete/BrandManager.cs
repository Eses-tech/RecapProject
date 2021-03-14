using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        IBrandDal _branDal;

        public BrandManager(IBrandDal branDal)
        {
            _branDal = branDal;
        }

        public void Add(Brand entity)
        {
            _branDal.Add(entity);
        }

        public void Delete(Brand entity)
        {
            _branDal.Delete(entity);
        }

        public List<Brand> GetAll()
        {
            return _branDal.GetAll();
        }

        public Brand GetById(int id)
        {
            return _branDal.Get(b => b.BrandId == id);
        }

        public void Update(Brand entity)
        {
            _branDal.Update(entity);
        }
    }
}
