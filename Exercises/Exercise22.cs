using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 2.	Write function that reverses a list, preferably in place.
    /// </task_description>
    public class Exercise22 : Exercise 
    {
        public override void ExerciseRun()
        {
            List<int> numList = new List<int> { 0, 1, 2, 3, 4, 5 };

            Console.WriteLine("Before reversing");
            ShowList(numList);

            ReverseList(numList);
            Console.WriteLine("After reversing");
            ShowList(numList);

            Console.WriteLine("And now the list was back-reversed by native method Reverse:");
            numList.Reverse();
            ShowList(numList);

            List<int> anotherNumberList = new List<int> { 10, 11, 12, 13, 14 };
            Console.WriteLine("One more list before reversing");
            ShowList(anotherNumberList);

            ReverseList(anotherNumberList);
            Console.WriteLine("And after");
            ShowList(anotherNumberList);

            Console.WriteLine();
        }
        public static List <int> ReverseList (List<int> list)
        {
            int tempContainer;
            int firstHalfPointer;
            int secondHalfPointer;
            if (list.Count % 2 == 0)
            {
                secondHalfPointer = list.Count / 2;
                firstHalfPointer = secondHalfPointer - 1;
            }
            else
            {
                firstHalfPointer = list.Count / 2 - 1;
                secondHalfPointer = list.Count / 2 + 1;
            }
            for (; secondHalfPointer < list.Count; secondHalfPointer++, firstHalfPointer--)
            {
                tempContainer = list [firstHalfPointer];
                list [firstHalfPointer] = list [secondHalfPointer];
                list [secondHalfPointer] = tempContainer;
            }
            return list;
        }
        
        public static void ShowList (List <int> list)
        {
            Console.Write ($"list contains: ");
            foreach (int number in list) Console.Write($" {number},");
            Console.WriteLine();
        }
        

    }
}
