using _Businuse.Concrete;
using _DataAccess.Concrete;
using _DataAccess.Context;
using _Entities.Abstract;
using System;

namespace _ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManeger s1 = new CarManeger(new EfCarDal());

            //var Result = s1.GetById(2);

            //Console.WriteLine(Result.DailyPrice);

            CarManeger car = new CarManeger(new EfCarDal());

            //var Information = new Cars
            //{
            //    CarId = 10,
            //    BrandName = "Honda",
            //    ColorName = "Read",
            //    DailyPrice = 0, 
            //    ModelYear = 2017,
            //    Description = "Sehrin Icinde"
            //};

            //car.Add(Information);

            
            //-----------------
            
            
            //var result = car.GetAll();

            //if (result.Success == true)
            //{
            //    foreach (var P in result.Data)
            //    {
            //        Console.WriteLine("{0}  ---  {1}  ---  {2}", P.CarId, P.BrandName, P.DailyPrice);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine(result.Message);
            //}

            //var result1 = car.GetById(15);
            //var P = result1.Data;
            
            //if(result1.Success == true)
            //{
            //    Console.WriteLine("{0}  ---  {1}  ---  {2}", P.CarId, P.BrandName, P.DailyPrice);
            //}
            //else
            //{
            //    Console.WriteLine(result1.Message);
            //}
            
                          
            Console.ReadKey();
        }
    }
}
