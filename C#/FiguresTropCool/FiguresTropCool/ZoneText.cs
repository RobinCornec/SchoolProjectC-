using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresTropCool
{
    public class ZoneText : Element
    {
        Double xB;
        Double yB;
        String Text;

        public ZoneText(Double xA, Double yA, Double xB, Double yB, String Text)
            : base(xA, yA) 
        {
            xA = this.xA;
            yA = this.yA;
            xB = this.xB;
            yB = this.yB;
            Text = this.Text;
        }
    }
}
