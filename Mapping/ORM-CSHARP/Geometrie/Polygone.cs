using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometrie
{
    public abstract class Polygone:IForme, IEnumerable<Point>
    {
        private List<Point> lesPoints;

        public Point this[int index]
        {
            get { return this.lesPoints[index]; }
        }

        public int Count
        {
            get { return this.lesPoints.Count; }
        }

        public Polygone(Point p1, Point p2, Point p3,
                        params Point[] autresPoints)
        {
            this.lesPoints = new List<Point>();
            this.lesPoints.Add(p1);
            this.lesPoints.Add(p2);
            this.lesPoints.Add(p3);
            this.lesPoints.AddRange(autresPoints);
        }

        public double CalculerPerimetre()
        {
            double res = 0;
            
            for (int i = 0; i < Count-1; i++)
                res += this[i].CalculerDistance(this[i + 1]);
            
            res += this[0].CalculerDistance(this[Count - 1]);

            return res;
        }

        public abstract double CalculerSurface();

        public IEnumerator<Point> GetEnumerator()
        {
            //for (int i = 0; i < Count; i++)
            //{
            //    yield return this[i];
            //}
            return this.lesPoints.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
