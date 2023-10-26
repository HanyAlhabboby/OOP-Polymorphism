using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public Cirkel()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
    }
    }

    
}
