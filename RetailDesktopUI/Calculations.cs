﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailDesktopUI
{
    public class Calculations : ICalculations
    {
        public List<string> Register { get; set; }

        public double Add(double x, double y)
        {
            return x + y;
        }
    }
}
