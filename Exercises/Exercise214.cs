using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    /// <task_description>
    /// 14.	Write a function that takes a number and returns a list
    /// of its digits. So for 2342 it should return [2,3,4,2].
    /// </task_description>
    public class Exercise214 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list = DecomposeNumber(AskForNumber());
            Console.WriteLine("The numberwas decomposed to digits, which were put in list");
            list.ShowList();
        }

        public static List<int> DecomposeNumber(int number)
        {
            List<int> listOfDigitsOfNumber = new List<int>();
            while (number != 0)
            {
                listOfDigitsOfNumber.Add((number % 10));
                number /= 10;
            }

            listOfDigitsOfNumber.Reverse();
            return listOfDigitsOfNumber;
        }

        /* Была мысль вынести метод в класс-хелпер, сделать его общим для всех упражнений.
        * Но при сравнении подобных "аскеров" в иных упражнениях не выявлено ни одного 
        * абсолютно одинкакового метда. Они все отличаются:
        * - один требует только положительных чисел;
        * - другой требует, чтобы число было не менее четырех;
        * - третий, помимо проверки на число, проверяет еще и наличие введенного числа в списке;
        * - текущий метод требует только чтобы число было целочисленным.        
        * Посему решил оставить этот метод здесь.*/
        public static int AskForNumber()
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
