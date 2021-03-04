using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            
            foreach (var car in carManager.GetAll())
            {
                Console.WriteLine(car.Id);
                Console.WriteLine(car.BrandId);
                Console.WriteLine(car.ColorId);
                Console.WriteLine(car.DailyPrice);
                Console.WriteLine(car.Descriptions);
                Console.WriteLine("----------------");
            }
        }
    }
}
