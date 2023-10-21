using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopPymorphism
{
    class Rektangel : Geometri___
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public Rektangel(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double Area()
        {
            return Length * Width;
        }
    }
}
