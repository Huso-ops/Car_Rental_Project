using Business.Concrete;
using DataAccess.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarTest();
            //ColorTest();

            static void CarTest()
            {
                CarManager carManager = new CarManager(new EfCarDal());

                var result = carManager.GetCarDetails();

                if (result.Success==true)
                {
                    foreach (var car in result.Data)
                    {
                        Console.WriteLine(car.CarName + "/" + car.ColorName);
                    }
                   
                } else
                    {
                        Console.WriteLine(result.Message);
                    }

               
            }

            static void ColorTest()
            {
                ColorManager colorManager = new ColorManager(new EfColorDal());
                foreach (var car in colorManager.GetAll())
                {
                    Console.WriteLine(car.ColorName);
                }
            }
        }
    }
}
