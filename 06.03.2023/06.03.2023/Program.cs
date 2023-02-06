using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Reflection;

namespace _06._03._2023
{

   
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Notebook ntb1 = new Notebook("MSI", "Sword 17")
            {
               
                Price = 250,
            };
            ntb1.ShowInfo();
            Notebook ntb2 = new Notebook("Acer", "Spin 3")
            {
               
                Price = 150,
            };
            ntb2.ShowInfo();

            Notebook[] notebooks = new Notebook[] { ntb1, ntb2 };
            var sum = 0;
            var result = 0;
            var count = 0;
            for (int i = 0; i < notebooks.Length; i++)
            {
                sum += notebooks[i].Price;
                count++;

            }
            result = sum / count;

            Console.WriteLine(result);

        }
    }
}
