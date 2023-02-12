using System;
using System.Collections.Generic;
using System.Text;

namespace _09._02._2023
{
    internal class Product
    {
        string _name;
        double _price;
        public double DiscountPercent;


        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                if (!string.IsNullOrWhiteSpace(value) && value.Length >= 2 && char.IsUpper(value[0])) 

                _name = value;

            }
        }
        public double Price
        {
            get
            {
                return _price;
            }



            set
            {
                if (value >= 0) ;
                _price = value;

            }



        }

    }
}

