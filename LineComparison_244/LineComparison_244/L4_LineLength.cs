using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison_244
{
    internal class L4_LineLength
    {
        public double GetLineLength(double x1, double y1, double x2, double y2)
        {
            double length = Math.Sqrt((Math.Pow((x2 - x1), 2)) + (Math.Pow((y2 - y1), 2)));
            return length;
        }
    }
}
