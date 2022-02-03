using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Realoops
{
    internal class RectangleArea : abstracton
    {
        private double length;
        private double width; 
        public RectangleArea(double length,double width ) :base()
        {
            this.length = length;
            this.width = width;
        }

        public override double Getarea()
        {
            return length * width;
        }
    }
}
