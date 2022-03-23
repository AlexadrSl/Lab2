using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab21
{
    class Square : Figure
    {
        public double Side { get; set; }
        public override double GetArea()
        {
            return Side * Side;
        }
    }
}


