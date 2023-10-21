using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPymorphism
{
    class Fyrkant : Geometri___
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Fyrkant()
        {
            Length = 5; 
            Width = 5; 
        }

        public override double Area()
        {
            return Length * Width;
        }
    }
}
