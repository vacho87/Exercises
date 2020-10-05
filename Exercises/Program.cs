using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.CodeDom;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
             //Elementary/Exercise 1
            {
                //Console.WriteLine("Hello world!");
            }

            //Elementary/Exercise 2
            {
                //Console.WriteLine("Enter your name and press \"Enter\" ");
                //string name = Console.ReadLine();
                //Console.WriteLine($"Hi {name}!");
            }


            //Elementary/Exercise 3
            {
                //Console.WriteLine("Enter your name and press \"Enter\" ");
                //string name1 = Console.ReadLine();
                //string greeting = name1 == "Alice" || name1 == "Bob" ? $"Hi {name1}!" : "Sorry, such name is unknown";
                //Console.WriteLine(greeting);

            }

            
            var ob = new ExerciseRunner();
            ob.Run();



            Console.ReadKey();

        }
    }
}
