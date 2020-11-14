using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class ServiceClass
    {
        public static int exerciseNumber;
        public static int AskChoice ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEnter Exercise number from the number 4 (4, 5, 6, etc.) and press \"Enter\"\n");
            Console.ResetColor();
            string input = Console.ReadLine();
                   
            while (!InputIsCorrectExerciseNumber(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError! Inputed data is incorrect. Please, enter some integer positive number from 4 to n");
                Console.ResetColor();
                input = Console.ReadLine();
            }

            return exerciseNumber;
        }

        public static bool InputIsCorrectExerciseNumber(string str)
        {
            if (int.TryParse(str, out int result) && result >= 4)
            {
                exerciseNumber = result;
                return true;
            }
            else return false;
        }

        static uint positiveIntegerNumber;

        public static uint InputPositiveIntegerNumber()
        {
            Console.WriteLine("Enter some arbitary integer positive number and press \"Enter\"");
            string input = Console.ReadLine();
            while (!InputIsPositiveInteger(input))
            {
                Console.WriteLine("Error! Entered data is incorrect. Please, enter some arbitary integer positive number");
                input = Console.ReadLine();
            }

            return positiveIntegerNumber;
        }

        static bool InputIsPositiveInteger(string str)
        {
            if (uint.TryParse(str, out uint result) && result >= 1)
            {
                positiveIntegerNumber = result;
                return true;
            }
            else return false;
        }


        public static int InputAnyIntegerNumber()
        {
            Console.WriteLine("\nEnter some integer number to decompose it to digits");
            bool inputedDataIsNumber = int.TryParse(Console.ReadLine(), out int number);
            while (!inputedDataIsNumber)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error! Data that you've inputed is not an integer number. Try again\n" +
                        "Enter some integetr number");
                Console.ResetColor();
                inputedDataIsNumber = int.TryParse(Console.ReadLine(), out number);
            }

            return number;

        }

    }
}
