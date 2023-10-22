using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Cirkel : Geometri
    {
        public double Radius { get; set; }
        public Cirkel() 
        {
            Radius = 5;
        }

        public override double Area() { return Math.PI * Radius * Radius; }
    }
}
