using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    // <task_description>
    /// 12.	Write a function that rotates a list by k elements.
    /// For example [1,2,3,4,5,6] rotated by two becomes [3,4,5,6,1,2].
    /// Try solving this without creating a copy of the list.
    /// How many swap or move operations do you need?
    /// </task_description>
    public class Exercise212 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            list.ShowList();
            int chosenElement = AskForListElement(list);
            RotateListByKElement(list, chosenElement);
            Console.WriteLine($"The list, rotated be element \"{chosenElement}\" looks like:");
            list.ShowList();            
        }

        public static void RotateListByKElement (List <int> list, int kElement)
        {
            int indexOfKElement = list.IndexOf(kElement);
            list.AddRange(list.GetRange(0, indexOfKElement+1));
            list.RemoveRange(0, indexOfKElement+1);            
        }

        public static int AskForListElement (List <int> list)
        {
             
            Console.WriteLine("\nEnter some number that the list contains to rotate the list");
            bool inputedDataIsNumber = int.TryParse(Console.ReadLine(), out int element);
            while (!inputedDataIsNumber || !list.Contains(element))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                if (!inputedDataIsNumber)
                {
                    Console.WriteLine("Error! Data that you've inputed is not an integer number. Try again\n" +
                        "Enter some number that the list contains");                   
                }
                else
                {
                    Console.WriteLine("Error! The list doesn't contain numder you've inputed. Try again\n" +
                        "Enter some number that the list contains");
                }
                Console.ResetColor();
                inputedDataIsNumber = int.TryParse(Console.ReadLine(), out element);
            }
            
            return element;
        }


    }
}
