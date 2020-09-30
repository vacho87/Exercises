using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class NumberInput
    {
        public int Input ()
        {
            Console.WriteLine("Enter any arbitary even positive number");
            string input = Console.ReadLine();
            int result;
            while (!int.TryParse(input, out result)||result<=0)
            {
                Console.WriteLine("Error! Inputed data is incorrect. Please, enter even number");
                input = Console.ReadLine();
            }
            return result;
        }
    }
}


