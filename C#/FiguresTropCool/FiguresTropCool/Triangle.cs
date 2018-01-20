using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresTropCool
{
    public class Triangle : Figure
    {
        Double xB;
        Double yB;
        Double xC;
        Double yC;

        public Triangle(Double xA, Double yA, Double xB, Double yB, Double xC, Double yC)
            : base(xA, yA) 
        {
            xA = this.xA;
            yA = this.yA;
            xB = this.xB;
            yB = this.yB;
            xC = this.xC;
            yC = this.yC;
        }
    }
}
