using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
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

        public IResult Add(Brand entity)
        {
            _branDal.Add(entity);
            return new SuccessResult(Messages.Yes);
        }

        public IResult Delete(Brand entity)
        {
            _branDal.Delete(entity);
            return new SuccessResult(Messages.Yes);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            return new SuccessDataResult<List<Brand>>(_branDal.GetAll(),Messages.Yes);
        }

        public IDataResult<Brand> GetById(int id)
        {
            return new SuccessDataResult<Brand>(_branDal.Get(b => b.BrandId == id), Messages.Yes);
        }

        public IResult Update(Brand entity)
        {
            _branDal.Update(entity);
            return new SuccessResult(Messages.Yes);
        }
    }
}
