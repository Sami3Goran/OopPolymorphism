using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPymorphism
{
    
    class Ellips : Geometri___
    {
        public double MajorAxis { get; set; }
        public double MinorAxis { get; set; }

        public Ellips()
        {
            MajorAxis = 7;
            MinorAxis = 4;
        }



        public override double Area()
        {
            return MajorAxis * MinorAxis * Math.PI;
        }
    }
}
