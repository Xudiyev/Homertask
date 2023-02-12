using System;
using System.Collections.Generic;
using System.Text;

namespace _11._02._2023
{
    internal class Group
    {
        string _no;
        double _avgPoint;



        public string No
        {
            get
            {
                return _no;
            }

            set
            {
                if (value.Length == 4 && char.IsUpper(value[0]))
                {
                    _no = value;
                }


            }
        }
        public double AvgPoint
        {
            get
            {
                return _avgPoint;
            }
            set
            {
                if (value >= 0 && value <= 100)
                    _avgPoint = value;
            }
        }
    }
}
