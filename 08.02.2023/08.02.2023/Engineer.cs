﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._02._2023
{
    internal class Engineer:Employee
    {

        public override double Salary
        {
            get
            {
                return _salary;
            }

            set
            {
                if (value >= 1000)
                    _salary = value;
            }

        }

    }
}
