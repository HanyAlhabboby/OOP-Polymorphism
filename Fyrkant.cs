using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Polymorphism
{
    internal class Fyrkant : Geometri //barn klass ärver från bas klassen
    {
        public double Side { get; set; }
        public Fyrkant()
        {
            Side = 4;
        }

        public override double Area() //metod som blir övertagen från bas klassen
        {
            return Side * Side; //area räkning på en fyrkant
        }
    }

   
}
