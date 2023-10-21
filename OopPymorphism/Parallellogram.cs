using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPymorphism
{
    class Parallellogram : Geometri___
    {
        public double BaseLength { get; set; }
        public double height { get; set; }

        public Parallellogram()
        {
            BaseLength = 4;
            height = 6;
        }

        public override double Area()
        {
            return BaseLength * height;
        }
    }
}
