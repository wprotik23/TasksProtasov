using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Rectangle
    {
        public int xLT;
        public int yLT;
        public int xRD;
        public int yRD;

        public Rectangle(int xLT, int yLT, int xRD, int yRD )
        {
            this.xLT = xLT;
            this.yLT = yLT;
            this.xRD = xRD;
            this.yRD = yRD;
            

        }

        public int plus_x()
        {
            int plus_x = (this.xRD - this.xLT) > 0 ? plus_x = (this.xRD - this.xLT) : plus_x = (-this.xRD + this.xLT);
            return plus_x;
        }

        public int plus_y()
        {
            int plus_y = (this.yRD - this.yLT) > 0 ? plus_y = (this.yRD - this.yLT) : plus_y = (-this.yRD + this.yLT);
            return plus_y;
        }

        public int Perumetr()
        {
            return ( plus_x() + plus_y() ) * 2;
        }

        public int Square()
        {
            return plus_x() * plus_y();     

        }
    }
}
