using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Square3:Figure3,IDrawable
    {
        public Square3() : base() { }
        public Square3(int x, int y) : base(x, y)
        {

        }
        public override void Draw()
        {
            Console.WriteLine("I am Square3");
        }
        public void DrawInt()
        {
            Console.WriteLine("I am Square_Intarface");
        }
    }
}
