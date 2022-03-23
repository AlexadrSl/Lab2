using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Decagon : Figure
    {
        public double Side { get; set; }

        public override double GetArea()
        {
            return (10 * Side * Side) / (4 * 0.32);
        }
    }
}

