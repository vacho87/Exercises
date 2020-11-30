using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <summary>
    /// <task_description>
    /// 16. Write a function that takes a list of numbers, a starting base b1
    /// and a target base b2 and interprets the list as a number in base b1
    /// and converts it into a number in base b2 (in the form of a list-of-digits). 
    /// So for example [2,1,0] in base 3 gets converted to base 10 as [2,1]
    /// </task_description>
    /// </summary>
    public class Exercise216 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("***This programm will decompose any integer number, that" +
                " you enter,  to list of digits in base 10. And then it will be converted between two" +
                " another bases that you will chose***");

            int number = ServiceClass.InputAnyIntegerNumber("Enter any integer number to decompose it to digits in base 10");
            DigitList list = new DigitList(number);

            Console.Write("\nSET first number base to convert number >>>");
            byte base1 = (byte)ServiceClass.InputNumberBaseNumber();
            list.ChangeBase(base1);
            list.ShowListOfDigits();

            Console.Write("\nSET first number base to convert number >>>");
            byte base2 = (byte)ServiceClass.InputNumberBaseNumber();
            list.ChangeBase(base2);
            list.ShowListOfDigits();
        }
    }
}
