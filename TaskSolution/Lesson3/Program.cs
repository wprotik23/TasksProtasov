using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson3");
            #region task12
            var rect = new Rectangle();
            rect.Draw();
            
            var square = new Square();
            square.Draw();
            Console.WriteLine("");
            #endregion

            #region task3
            Console.WriteLine("task3");
            var rect3 = new Rectangle3();
            rect3.Draw();

            var square3 = new Square3();
            square3.Draw();

            Figure3 f3 = new Figure3();
            f3.Draw();
            Console.WriteLine("");
            #endregion

            #region task4
            Console.WriteLine("task4");
            var array = new Figure3[] {rect3,square3,f3 };
            DrawAll(array);

            #endregion
            Console.ReadLine();
        }

        private static void DrawAll(params IDrawable[] array)
        {
            foreach (var i in array)
            {
                i.DrawInt();
            }
        }
    }
}
