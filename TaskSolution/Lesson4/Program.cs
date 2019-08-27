using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        public static void DisplayPage(int pageNumber, List<string> list)
        {
            
            for (int i = 0; i < 5; i++)
            {
                int t = i + (pageNumber - 1) * 5;
                Console.WriteLine(list[t]);
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Lesson4");

            //task1
            List<Person> list1;
            list1 = new List<Person>();

            var pnumb1 = new List<string> { "123", "234", "345", "456" };
            var pnumb2 = new List<string> { "234", "345" };
            var pnumb3 = new List<string> { "133", "7834", "39845" };
            var pnumb4 = new List<string> { "143", "7745" };
            var pnumb5 = new List<string> { "523", "98234", "32345" };



            Person p1 = new Person("Andrii", 23, pnumb1);
            Person p2 = new Person("Bogdan", 34, pnumb2);
            Person p3 = new Person("Carl", 27, pnumb3);
            Person p4 = new Person("Denys", 56, pnumb4);
            Person p5 = new Person("Evgen", 19, pnumb5);

            list1.Add(p1);
            list1.Add(p2);
            list1.Add(p3);
            list1.Add(p4);
            list1.Add(p5);

            foreach (Person p in list1)
            {
                Console.WriteLine(p.name + "  " + p.age);
            }

            
            //task2

            var pnumb6 = new List<string> { "523", "98234", "32345", "143", "7745" };
            var pnumb7 = new List<string> { "523", "98234", "32345" };

            Person p7 = new Person("Fedir", 16, pnumb6);
            Person p8 = new Person("George", 79, pnumb7);

            var list2 = new List<Person> { p7, p8};
            list1.AddRange(list2);

            Console.WriteLine("Task2");

            foreach (Person p in list1)
            {
                Console.WriteLine(p.name + "  " + p.age);
            }



            //task3

            //zapovnennia
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";


            var list3 = new List<string>();

            for (int i = 0; i < 111; i++)
            {
                StringBuilder result = new StringBuilder(4);
                for (int j = 0; j < 4; j++)
                {
                    result.Append(characters[random.Next(characters.Length)]);
                }

                list3.Add(result.ToString());


            }
            Console.WriteLine(list3.Count);

            //Vudalennia "Z"
            for (int i=0;i<list3.Count;i++)
            {
                if (list3[i].StartsWith("Z"))
                {
                    list3.RemoveAt(i);
                }
            }                      
            list3.Distinct();
            list3.Sort();
            list3.Reverse();

            Console.WriteLine(list3.Count);
            Console.WriteLine("Enter Page");
            string Numb = Console.ReadLine();

            try
            {
                int page = Convert.ToInt32(Numb);
                DisplayPage(page, list3);
            }

            catch
            {
                return;
            }

            

            foreach (string s in list3)
            {
                //  Console.WriteLine(s);
            }


            Console.ReadKey();
            }
        
    }
}
