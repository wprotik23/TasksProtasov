using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Rectangle2
    {
        public int xLT;
        public int yLT;
        public int xRD;
        public int yRD;

        public int perumetr;
        public int square;

        public Rectangle2(int xLT, int yLT, int xRD, int yRD)
        {
            this.xLT = xLT;
            this.yLT = yLT;
            this.xRD = xRD;
            this.yRD = yRD;

            int plus_x = (this.xRD - this.xLT) > 0 ? plus_x = (this.xRD - this.xLT) : plus_x = (-this.xRD + this.xLT);
            int plus_y = (this.yRD - this.yLT) > 0 ? plus_y = (this.yRD - this.yLT) : plus_y = (-this.yRD + this.yLT);
            this.perumetr=(plus_x + plus_y) * 2;
            this.square = plus_x * plus_y;



        }

        
    }
}
