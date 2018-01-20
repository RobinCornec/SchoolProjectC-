using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Quadrilatere : Polygone
    {
        public Quadrilatere(Point p1, Point p2, Point p3, Point p4)
            : base(p1, p2, p3, p4) { }

        public override double CalculerSurface()
        {
            var t1 = new Triangle(this[0], this[1], this[2]);
            var t2 = new Triangle(this[0], this[1], this[3]);

            return t1.CalculerSurface() + t2.CalculerSurface();
        }
    }
}
