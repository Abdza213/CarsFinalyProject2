using DataAccess.Concrete;
using System;

namespace ConsoleIU
{
    class Program
    {
        static void Main(string[] args)
        {
            EfCarDal cars = new EfCarDal();

            foreach (var P in cars.GetAll())
            {
                Console.WriteLine(P.DailyPrice);
            }
            Console.ReadKey();
        }
    }
}
