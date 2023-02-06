using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _06._03._2023
{
    internal class Notebook
    {
        public Notebook(string brand,string model) 
        {
            Brand = brand;
            Model= model;
        }
        
        public string Brand;
        public string Model;
        public byte Price;

        public void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Price: {Price}");
        }
    }
}
