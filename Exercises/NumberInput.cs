using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    static class NumberInput
    {
        static uint number;
        public static uint Input ()
        {
            Console.WriteLine("Enter some arbitary integer positive number and press \"Enter\"");
            string input = Console.ReadLine();
            while (!InputIsCorrectExerciseNumber(input))
            {
                Console.WriteLine("Error! Inputed data is incorrect. Please, enter some arbitary integer positive number");
                input = Console.ReadLine();
            }
            
            return number;
        }

        static bool InputIsCorrectExerciseNumber (string str)
        {
            if (uint.TryParse(str, out uint result) && result >= 1)
            {
                number = result;
                return true;
            }
            else return false;
        }

    }
}
