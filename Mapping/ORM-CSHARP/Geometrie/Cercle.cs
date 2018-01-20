using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public class Cercle:IForme
    {
        public int Rayon { get; private set; }
        public Point Centre { get; private set; }

        public Cercle(int rayon, Point centre)
        {
            Centre = centre;
            Rayon = rayon;
        }

        public double CalculerPerimetre()
        {
            return 2 * Rayon * Math.PI;
        }

        public double CalculerSurface()
        {
            return Math.PI * Rayon * Rayon;
        }
    }
}
