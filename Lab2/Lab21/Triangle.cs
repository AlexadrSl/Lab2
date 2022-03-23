using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Triangle : Figure
    {
        public double Height { get; set; }
        public double Bottom { get; set; }
        public override double GetArea()
        {
            return 0.5 * Height * Bottom;
        }
    }
}
