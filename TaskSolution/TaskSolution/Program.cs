using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("lesson2 ");
            Console.WriteLine("Enter Task: ");
            int task = Convert.ToInt32(Console.ReadLine());
            #region task12
            if (task == 1 || task == 2)
            {
                Console.WriteLine("Enter rectangle points");
                Console.Write("xLT ");
                int xLT = Convert.ToInt32(Console.ReadLine());

                Console.Write("yLT ");
                int yLT = Convert.ToInt32(Console.ReadLine());

                Console.Write("xRD ");
                int xRD = Convert.ToInt32(Console.ReadLine());

                Console.Write("yRD ");
                int yRD = Convert.ToInt32(Console.ReadLine());

                if (task == 1)
                {

                    var rect = new Rectangle(xLT, yLT, xRD, yRD);

                    Console.WriteLine("Perumetur {0} ", rect.Perumetr());
                    Console.WriteLine("Square {0}", rect.Square());
                }

                if (task == 2)
                {
                    var rect2 = new Rectangle2(xLT, yLT, xRD, yRD);

                    Console.WriteLine("Perumetur {0} ", rect2.perumetr);
                    Console.WriteLine("Square {0}", rect2.square);
                }
            }
            #endregion
            #region task3
            else if (task == 3)
            {
                Console.WriteLine("Enter Radius: ");
                int radius = Convert.ToInt32(Console.ReadLine());
                var cirle = new Circle(radius);
                Console.WriteLine("Lenght is {0} ", cirle.lenght(radius));
                Console.WriteLine("Square is {0}", cirle.Square(radius));
            }

            #endregion
            #region task4
            else if (task == 4)
            {
                Console.WriteLine("task 4");
                Console.Write("xLT ");

                StaticRectangle.xLT  = Convert.ToInt32(Console.ReadLine());
                
                Console.Write("yLT ");
                StaticRectangle.yLT = Convert.ToInt32(Console.ReadLine());

                Console.Write("xRD ");
                StaticRectangle.xRD = Convert.ToInt32(Console.ReadLine());

                Console.Write("yRD ");
                StaticRectangle.yRD = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Square is {0} ", StaticRectangle.Square());
                Console.WriteLine("Perimetr is {0} ", StaticRectangle.Perumetr());

                Console.WriteLine("Enter Radius: ");
                StaticCircle.radius  = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Lenght is {0} ", StaticCircle.lenght());
                Console.WriteLine("Square is {0}", StaticCircle.Square());
            }

            #endregion
            #region task5
            else if (task == 5)
            {
                Console.WriteLine("Enter Complex Numbers");

                var a = new ComplexNumber(0,0);
                var b = new ComplexNumber(0, 0);
                Console.Write("a.real ");
                a.real = Convert.ToInt32(Console.ReadLine());

                Console.Write("a.imaginary ");
                a.imaginarity = Convert.ToInt32(Console.ReadLine());

                Console.Write("b.real ");
                b.real = Convert.ToInt32(Console.ReadLine());

                Console.Write("b.imaginary ");
                b.imaginarity = Convert.ToInt32(Console.ReadLine());

                
                Console.WriteLine("a*b= {0} + {1}i ", (a * b).real, (a*b).imaginarity);
                Console.WriteLine("a/b={0} + {1} i", (a / b).real, (a / b).imaginarity); 

            }
            #endregion

            Console.ReadKey();

        }
    }
}
