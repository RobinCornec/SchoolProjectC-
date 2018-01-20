using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresTropCool
{
    public class Rectangle : Figure
    {
        Double xB;
        Double yB;

        public Rectangle(Double xA, Double yA, Double xB, Double yB)
            : base(xA, yA) 
        {
            xA = this.xA;
            yA = this.yA;
            xB = this.xB;
            yB = this.yB;
        }
    }
}
