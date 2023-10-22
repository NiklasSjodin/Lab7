using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Fyrkant : Geometri
    {
        public double Sides {  get; set; }

        public Fyrkant() 
        {
            Sides = 5;
        }

        public override double Area() { return Sides*Sides; }
    }
}
