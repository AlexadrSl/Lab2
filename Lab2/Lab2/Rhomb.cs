﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Rhomb : Figure
    {
        public double Side { get; set; }
        public double Height { get; set; }

        public override double GetArea()
        {
            return Side * Height;
        }
    }
}
