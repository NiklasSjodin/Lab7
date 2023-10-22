using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Ellips : Geometri
    {
        public double HemiMajorAxis {  get; set; }
        public double SemiMinorAxis { get; set; }

        public Ellips() 
        {
            HemiMajorAxis = 5; SemiMinorAxis = 10;
        }

        public override double Area() { return Math.PI * HemiMajorAxis * SemiMinorAxis; }
    }
}
