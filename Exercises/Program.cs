using System;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Elementary/Exercise 1
            {
                Console.WriteLine("Hello world!");
            }

            //Elementary/Exercise 2
            {
                Console.WriteLine("Enter your name and press \"Enter\" ");
                string name = Console.ReadLine();
                Console.WriteLine($"Hi {name}!");
            }


            //Elementary/Exercise 3
            {
                //Console.WriteLine("Enter your name and press \"Enter\" ");
                //string name1 = Console.ReadLine();
                //string greeting = name1 == "Alice" || name1 == "Bob" ? $"Hi {name1}!" : "Sorry, such name is unknown";
                //Console.WriteLine(greeting);

            }

            //Elementary/Exercise 4
            {
                //Console.WriteLine("Enter any arbitary even number");
                //int sum = 0;
                //int number = NumberInput();
                //int NumberInput()
                //{
                //    string input = Console.ReadLine();
                //    if (!int.TryParse(input, out int result))
                //    {
                //        Console.WriteLine("Error! Inputed data is incorrect. Please, enter even number");
                //        NumberInput();
                //    }
                //    return result;
                //}
                //for (int i = number; i > 0; i--)
                //{
                //    sum += i;
                //}
                //Console.WriteLine($"sum of numbers from 1 to {number} = {sum}");
            }


            //Elementary/Exercise 5

            {
                Console.WriteLine("Enter any arbitary even number");
                int sum = 0;
                int number = NumberInput();
                int NumberInput()
                {
                    string input = Console.ReadLine();
                    if (!int.TryParse(input, out int result))
                    {
                        Console.WriteLine("Error! Inputed data is incorrect. Please, enter even number");
                        NumberInput();
                    }
                    return result;
                }
                for (int i = number; i > 0; i--)
                {
                    if (i % 3 == 0 || i % 5 == 0)
                        sum += i;
                }
                Console.WriteLine($"sum of numbers from 1 to {number}, such that only multiples of three or five = {sum}");

            }

            //Elementary/Exercise 6




            Console.ReadKey();
        }
    }
}
