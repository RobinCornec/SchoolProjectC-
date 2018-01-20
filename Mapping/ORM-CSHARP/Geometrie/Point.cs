using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    /// <summary>
    /// représente un point dans un repère à deux dimensions
    /// </summary>
    public class Point
    {
        private int x;

        public int X
        {
            get { return x; }
            private set { x = value; }
        }

        public int Y { get; private set; }

        /// <summary>
        /// Constructeur de points
        /// </summary>
        /// <param name="abscisse">abscisse du point</param>
        /// <param name="ordonnee">ordonnée du point</param>
        public Point(int abscisse, int ordonnee)
        {
            X = abscisse;
            Y = ordonnee;
        }

        public double CalculerDistance(Point autrePoint)
        {
            return Math.Sqrt(
                    Math.Pow(X - autrePoint.X, 2)
                    +
                    Math.Pow(Y - autrePoint.Y, 2)
                );
        }

        public override string ToString()
        {
            return string.Format("({0},{1})", X, Y);
        }
    }
}
