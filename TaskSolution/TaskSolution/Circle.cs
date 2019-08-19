using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Circle
    {
        public int radius;
        private static double pi=3.14;

        public Circle(int rad)
        {
            this.radius = rad;
        }

        public double lenght(int radius)
        {
            return  radius * pi; 
        }
        public double Square(int radius)
        {
            return radius * radius * pi;
        }

    }
}
