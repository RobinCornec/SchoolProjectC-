using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Triangle : Polygone
    {
        public Triangle(Point p1, Point p2, Point p3)
            : base(p1, p2, p3) { }

        //http://fr.wikipedia.org/wiki/Formule_de_H%C3%A9ron
        public override double CalculerSurface()
        {
            var s = this.CalculerPerimetre();
            var a = this[0].CalculerDistance(this[1]);
            var b = this[0].CalculerDistance(this[2]);
            var c = this[2].CalculerDistance(this[1]);

            return Math.Sqrt(
                    s * (s - a) * (s - b) * (s - c)
                );
        }
    }
}
