﻿using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {

        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car> { new Car { Id=1,BrandId=1,ColorId=1,ModelYear="2000",DailyPrice=300,Description="Ekonomik"},
            new Car{Id=2,BrandId=2,ColorId=4,DailyPrice=784,ModelYear="2019",Description="Rahat"},
            new Car{Id=3,BrandId=6,ColorId=3,ModelYear="2017",DailyPrice=1000,Description="Hızlı"},
            new Car{Id=4,BrandId=2,ColorId=1,ModelYear="2018",DailyPrice=710,Description="Güvenilir"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete;
            carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate;
            carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;

            
        }
    }
}