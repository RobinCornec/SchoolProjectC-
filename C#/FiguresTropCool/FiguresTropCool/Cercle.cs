using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresTropCool
{
    public class Cercle : Figure
    {
        Double Diametre;

        public Cercle(Double xA, Double yA, Double Diametre) : base(xA, yA)
        {
            xA = this.xA;
            yA = this.yA;
            Diametre = this.Diametre;
        }
    }
}
