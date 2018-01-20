using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresTropCool
{
    public abstract class Figure : Element
    {
        public Figure(Double xA, Double yA)
            : base(xA, yA)
        {
            xA = this.xA;
            yA = this.yA;
        }
    }
}
