using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise21 : Exercise
    {
        /// <task_description>
        /// 1.	Write a function that returns the largest element in a list
        /// </task_description>
        public override void ExerciseRun()
        {
            int thelargestNumber = ReturnTheLargestIntElement(listOfNumbers);
            Console.WriteLine("\nThe largest element in the list of integer numbers:");
            foreach (int number in listOfNumbers) Console.Write($" {number},");
            Console.WriteLine($"determined with my method is {thelargestNumber},");
            Console.WriteLine($" determined with List's native method is {listOfNumbers.Max()}\n");

        }

        public static int ReturnTheLargestIntElement (List<int> list)
        {
            int theLargestInt = list[0];
            for (int i=1; i< list.Count;i++)
            {
                if (list[i] > theLargestInt) theLargestInt = list[i];
            }
            return theLargestInt;
        }

        List<int> listOfNumbers = new List<int> {12, 10, 4, 0, 22, 103, 13 ,56 ,75 ,99, 90, 104};


    }
}
