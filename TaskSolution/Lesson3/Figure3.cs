using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Figure3:IDrawable
    {
        public int x { get; }
        public int y { get; }
        public Figure3() { }
        public Figure3(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public virtual void Draw()
        {
            Console.WriteLine("I am Figure3");
        }
        public void DrawInt()
        {
            Console.WriteLine("I am Figure_interface");
        }
    }
}
