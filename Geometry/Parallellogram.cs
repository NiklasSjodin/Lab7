using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    internal class Parallellogram : Geometri
    {
        public double Base {  get; set; }
        public double Height { get; set; }

        public Parallellogram() 
        {
            Base = 5; Height = 10;
        }

        public override double Area() { return Base * Height; }
    }
}
