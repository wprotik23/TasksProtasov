using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Rectangle:Figure
    {
        public int x;
        public Rectangle() : base() { }
        public Rectangle(int x, int y):base(x,y)
            {

            }
        public override void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
