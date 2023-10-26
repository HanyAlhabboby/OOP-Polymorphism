using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Ellips : Geometri
    {
        public double LargeXaxis { get; set; } 
        public double SmallYaxis { get; set; }
        public Ellips()
        {
            LargeXaxis = 6;
            SmallYaxis = 3;
        }

        public override double Area()
        {
            return Math.PI * LargeXaxis * SmallYaxis;
        }

    }
}
