using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            ShowListOfInt(numList);

            ReverseList(numList);
            Console.WriteLine("After reversing");
            ShowListOfInt(numList);

            Console.WriteLine("And now the list was back-reversed by native method Reverse:");
            numList.Reverse();
            ShowListOfInt(numList);

            List<int> anotherNumberList = new List<int> { 10, 11, 12, 13, 14 };
            Console.WriteLine("One more list before reversing");
            ShowListOfInt(anotherNumberList);

            ReverseList(anotherNumberList);
            Console.WriteLine("And after");
            ShowListOfInt(anotherNumberList);

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
        
        public static void ShowListOfInt (List <int> list, string listName = "")
        {
            Console.Write ($"list {listName} contains: ");
            foreach (int number in list) Console.Write($" {number},");
            Console.WriteLine();
        }

        public static void ShowListofChar (List<char> list, string listName = "")
        {
            Console.Write($"list {listName} contains: ");
            foreach (char symbol in list) Console.Write($" {symbol},");
            Console.WriteLine();
        }

        public static void ShowListofObject (List<object> list, string listName = "")
        {
            Console.Write($"list {listName} contains: ");
            foreach (object obj in list) Console.Write($" {obj},");
            Console.WriteLine();
        }


    }
}
