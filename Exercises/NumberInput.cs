using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class NumberInput
    {
        int number;
        public int Input ()
        {
            Console.WriteLine("Enter any arbitary even (integer) positive number and press \"Enter\"");
            string input = Console.ReadLine();
            while (!InputIsOk(input))
            {
                Console.WriteLine("Error! Inputed data is incorrect. Please, enter arbitary even (integer) positive number");
                input = Console.ReadLine();
            }
            
            return number;
        }

        bool InputIsOk (string str)
        {
            if (int.TryParse(str, out int result) & result >= 1)
            {
                number = result;
                return true;
            }
            else return false;
        }

    }
}
