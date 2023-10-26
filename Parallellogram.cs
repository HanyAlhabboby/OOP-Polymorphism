using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Parallellogram :Geometri
    {
        public double Base {get; set; }
        public double Height { get; set; }
        public Parallellogram()
        {
            Base = 8;
            Height = 4;
        }

        public override double Area()
        {
            return Base * Height;
        }
    }
}
