using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Rectangle3:Figure3,IDrawable

    {
        public int x;
        public Rectangle3() : base() { }
        public Rectangle3(int x, int y):base(x,y)
            {

        }
        public override void Draw()
        {
            Console.WriteLine("I am Rectangle3");
        }
        public void DrawInt()
        {
            Console.WriteLine("I am Rectangle_Intarface");
        }
    }
}
