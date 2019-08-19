using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Square:Figure

    {
        public Square() : base() { }
        public Square(int x, int y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
