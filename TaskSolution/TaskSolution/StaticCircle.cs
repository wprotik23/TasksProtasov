using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    static class StaticCircle
    {

        public static int radius;
        private static double pi = 3.14;       

        public static double lenght()
        {
            return radius * pi;
        }
        public static  double Square()
        {
            return radius * radius * pi;
        }

    }
}
