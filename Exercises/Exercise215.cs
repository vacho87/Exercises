using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 15.	Write functions that add, subtract, and multiply two numbers
    /// in their digit-list representation (and return a new digit list).
    /// If you’re ambitious you can implement Karatsuba multiplication. 
    /// Try different bases. What is the best base if you care about speed?
    /// If you couldn’t completely solve the prime number exercise above due 
    /// to the lack of large numbers in your language, you can now use your own library for this task.
    /// </task_description>
    public class Exercise215 : Exercise
    {
        public override void ExerciseRun()
        {
           Console.WriteLine("\nThis programm will decompose two integer numbers to it's digits and then\n" +
                "will add, subtract or multiply them according to your choise");

            Console.WriteLine("Enter the first number");
            int firstNumber = Exercise214.AskForNumber();
            int secondtNumber = Exercise214.AskForNumber();
            List<int> resultList = AddTwoNumbersDigits(firstNumber, secondtNumber);
            Console.WriteLine("Digits, that contain the numbers were added to each other");
            resultList.ShowList("RESULTLIST");
        }

        public static List <int> AddTwoNumbersDigits (int number1, int number2)
        {
            List<int> number1Digits = Exercise214.DecomposeNumber(number1);
            number1Digits.Reverse();
            List<int> number2Digits = Exercise214.DecomposeNumber(number2);           
            number2Digits.Reverse();

            var biggerList = number1Digits.Count > number2Digits.Count ? number1Digits : number2Digits;
            var smallerList = biggerList == number1Digits ? number2Digits : number1Digits;

            List<int> resultList = new List<int>();
            int nextDigitIncrement = 0;
            int currentDigitInResultList;

            for (int i = 0; i < smallerList.Count; i++)
            {
                currentDigitInResultList = (number1Digits[i] + number2Digits[i] + nextDigitIncrement) % 10;
                nextDigitIncrement = (number1Digits[i] + number2Digits[i] + nextDigitIncrement) / 10;
                resultList.Add(currentDigitInResultList);
            }

            for (int i = smallerList.Count; i < biggerList.Count; i++)
            {
                resultList.Add(biggerList[i] + nextDigitIncrement);
                nextDigitIncrement = 0;
            }

            resultList.Reverse();
            return resultList;
        }

        public static List<int> MultiplyTwoNumbersDigits(int number1, int number2)
        {
            List<int> number1Digits = Exercise214.DecomposeNumber(number1);
            number1Digits.Reverse();
            List<int> number2Digits = Exercise214.DecomposeNumber(number2);
            number2Digits.Reverse();

            var biggerList = number1Digits.Count > number2Digits.Count ? number1Digits : number2Digits;
            var smallerList = biggerList == number1Digits ? number2Digits : number1Digits;

            List<int> resultList = new List<int>();
            int nextDigitIncrement = 0;
            int currentDigitInResultList;

            // WAITING
            // FOR 
            // IMPLEMENTATION

            resultList.Reverse();
            return resultList;
        }


    }
}
