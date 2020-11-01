using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class ExerciseChooser
    {
        public static int number;
        public static int AskChoice ()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nEnter Exercise number from the number 4 (4, 5, 6, etc.) and press \"Enter\"");
            Console.ResetColor();
            string input = Console.ReadLine();
                   
            while (!InputIsCorrectExerciseNumber(input))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError! Inputed data is incorrect. Please, enter some integer positive number from 4 to n");
                Console.ResetColor();
                input = Console.ReadLine();
            }

            return number;
        }

        public static bool InputIsCorrectExerciseNumber(string str)
        {
            if (int.TryParse(str, out int result) && result >= 4)
            {
                number = result;
                return true;
            }
            else return false;
        }

               
        
    }
}
