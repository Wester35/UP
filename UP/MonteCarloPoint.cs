using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    // Класс представляет одну точку, использующуюся в методе Монте-Карло.
    public class MonteCarloPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public bool InSegment { get; set; }

        public MonteCarloPoint(double x, double y, bool inSegment)
        {
            X = x;
            Y = y;
            InSegment = inSegment;
        }
    }
}
