using Business.Abstract;
using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        public IResult Add(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(CarImage entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<CarImage> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(CarImage entity)
        {
            throw new NotImplementedException();
        }
    }
}
