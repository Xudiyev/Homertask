using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace _07_02_2023
{
    internal class Car : Vehicle
    {

         public double FuelCapacity;

        public override void ShowInfo()
        {
            Console.WriteLine($"Brand: {Brand} - Model: {Model} - Millage: {Millage}  FuelCapacity: {FuelCapacity}");
        }
    }
}
