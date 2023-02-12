using System;

namespace _09._02._2023
{
    internal class Program
    {
        static void Main(string[] args)
        {



            Product pr1 = new Product();
            pr1.Name = "Coca cola 1L";
            pr1.Price = -100;
            pr1.DiscountPercent = 100;

            Console.WriteLine(pr1.Price);
            Console.WriteLine(pr1.Name);



            string str = "";
            Console.WriteLine(string.IsNullOrEmpty(str));
            Console.WriteLine(string.IsNullOrWhiteSpace(str));


            //string str = "";
            //Console.WriteLine(string.IsNullOrEmpty(str));
            //Console.WriteLine(string.IsNullOrWhiteSpace(str));


            //Store store = new Store();
            //store.AddProducts(pr1);
            //store.AddProducts(new Product { Name = "Pepsi", Price = 20 });

            //for (int i = 0; i < store.Products.Length; i++)
            //{
            //    Console.WriteLine(store.Products[i].Name+ "-"+store.Products[i].Price);
            //}


        }
    }
}
