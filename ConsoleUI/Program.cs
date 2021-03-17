using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarAdd();
            //CarDelete();
            //CarUpdate();
            //CarGetAll();
            //CarGetById();
            //CarGetDetail();
            //-------------------
            //BrandAdd();
            //BrandDelete();
            //BrandUpdate();
            //BrandGetALL();
            //BrandGetById();
            //--------------------
            //ColorAdd();
            //ColorDelete();
            //ColorUpdate();
            //ColorGetById();
            //ColorGetAll();


        }

        private static void CarGetDetail()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.CarName + "/" + car.BrandName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void ColorGetAll()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var color in colorManager.GetAll().Data)
            {
                Console.WriteLine(color.ColorName);
            }
        }

        private static void ColorGetById()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            Console.WriteLine(colorManager.GetById(6).Data.ColorName);
        }

        private static void ColorUpdate()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Update(new Color { ColorId = 6, ColorName = "Parlament Mavi" });
        }

        private static void ColorDelete()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Delete(new Color { ColorId = 7 });
        }

        private static void ColorAdd()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color { ColorName = "Gri" });
        }

        private static void BrandGetById()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            Console.WriteLine(brandManager.GetById(4).Data.BrandName);
        }

        private static void BrandGetALL()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll().Data)
            {
                Console.WriteLine(brand.BrandName);
            }
        }

        private static void BrandUpdate()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Update(new Brand { BrandId = 6, BrandName = "Volvo" });
        }

        private static void BrandDelete()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Delete(new Brand { BrandId = 6 });
        }

        private static void BrandAdd()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            brandManager.Add(new Brand { BrandName = "Nissan" });
        }

        private static void CarGetById()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Console.WriteLine(carManager.GetById(1009).Data.CarName + "/" + carManager.GetById(1009).Data.Descriptions);
        }

        private static void CarGetAll()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetCarDetails().Data)
            {
                Console.WriteLine(car.BrandName + "/" + car.CarName + "/" + car.ColorName + "/" + car.DailyPrice);
            }
        }

        private static void CarUpdate()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Update(new Car { Id = 1011, BrandId = 4, ColorId = 4, CarName = "Golf", ModelYear = "2001", DailyPrice = 511, Descriptions = "Manuel" });
        }

        private static void CarDelete()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            //Yalnızca Id yazarak silme islemini gerceklestirebilirsiniz..
            carManager.Delete(new Car { Id = 1010 });
        }

        private static void CarAdd()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            carManager.Add(new Car { BrandId = 4, ColorId = 4, CarName = "Polo", DailyPrice = 550, Descriptions = "Manuel", ModelYear = "2000" });
        }
    }
    
}
