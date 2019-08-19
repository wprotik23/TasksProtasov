using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    static class StaticRectangle
    {
        public static int xLT;
        public static int yLT;
        public static int xRD;
        public static int yRD;

        static StaticRectangle()
        {
          

        }

        public static int plus_x()
        {
            int plus_x = (xRD - xLT) > 0 ? plus_x = (xRD - xLT) : plus_x = (xRD + xLT);
            return plus_x;
        }

        public static int plus_y()
        {
            int plus_y = (yRD -yLT) > 0 ? plus_y = (yRD - yLT) : plus_y = (-yRD + yLT);
            return plus_y;
        }

        public static int Perumetr()
        {
            return (plus_x() + plus_y()) * 2;
        }

        public static int Square()
        {
            return plus_x() * plus_y();

        }
    }
}

