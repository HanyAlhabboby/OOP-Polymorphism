using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Rektangel : Geometri
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public Rektangel()
        {
            Length = 8;
            Width = 4;
        }

        public override double Area ()
        {
            return Length * Width;
        }
    } 

   
}
