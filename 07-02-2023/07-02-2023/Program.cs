using System;
using System.Globalization;

namespace _07_02_2023
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime();

            Console.WriteLine("Tarix daxil edin:");
            string dateStr = Console.ReadLine();
            date = Convert.ToDateTime(dateStr);
            date = date.AddYears(25);

            Console.WriteLine(date);
            Console.WriteLine(date.ToString("MM-dd-yy HH:mm"));




            Car car1 = new Car
            {
                Brand = "BMW",
                Model = "M8",
                Millage = 5500,
                FuelCapacity = 70,
            };

            car1.ShowInfo();


            Bicycle byc = new Bicycle
            {
                Brand = "Bmx",
                Model = "M",
                Millage = 34,
            };

            byc.ShowInfo();


        }
    }
}
