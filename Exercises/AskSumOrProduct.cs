using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    static class AskSumOrProduct
    {
        public static string Ask()
        {
            Console.WriteLine("For computing the sum of numbers from 1 to ... n enter \"s\" and press \"Enter\" \n" +
                              "For computing the product of numbers from 1 to ... n enter \"p\" and press \"Enter\" \n" +
                              "Or enter \"e\" and press \"Enter\" to exit");
            string input = Console.ReadLine();
            while (input != "s" && input != "p" && input != "e")
            {
                Console.WriteLine("Error!!! Inputed data is incorrect!\n" +
                             "Enter \"s\", \"p\" or \"e\" and press \"Enter\" to exit");
                input = Console.ReadLine();
            }

            if (input == "e") Console.WriteLine("Task skipped");
            return input;
        }
    }
}
