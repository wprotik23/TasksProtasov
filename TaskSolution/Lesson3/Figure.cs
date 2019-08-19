using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    abstract class Figure
    {
        public int x { get; } 
        public int y { get; }
        public Figure() { }
        public Figure(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public abstract void Draw();

    }
}
