using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UP
{
    public class ResultEntry
    {
        public int Id { get; set; }
        public double Formula { get; set; }
        public double MonteCarlo { get; set; }
        public double Difference => Math.Abs(Formula - MonteCarlo);
    }
}
