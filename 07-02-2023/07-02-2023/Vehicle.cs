using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml;

namespace _07_02_2023
{
    internal class Vehicle
    {
      
        
       
        public string Brand;
        public string Model;
        public double Millage;

        



        public virtual void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage}");
         }
    }


}