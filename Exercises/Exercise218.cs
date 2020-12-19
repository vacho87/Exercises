using System;
using System.Collections.Generic;

namespace Exercises
{
    public class Exercise218 : Exercise
    {
        /// <summary>
        ///  <task_description>
        /// 18.	Implement binary search.
        ///  </task_description>
        /// </summary>
        public override void ExerciseRun()
        {
            List<int> list = new List<int> { 0, 1, 1, 1, 2, 4, 7, 10, 14, 45, 101 };
            list.ShowList();
            Console.WriteLine();
            int[] itemsToSearch = new int[] { 4, 5, 101, 7, 0, 1 };

            foreach (int item in itemsToSearch)
            {
                int index = BinarySearch(list, item);
                if (index == -1 )
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"!!! Number {item} was not found in the list.");
                    Console.ResetColor();
                }
                else
                {                   
                    Console.WriteLine($"Position of number {item} in the list is {index + 1}");                   
                }

            }
                                   
        }

        /// <summary>
        /// Search the first place where stored the required number in list of integers, sorted in ascending order 
        /// </summary>
        /// <param name="list"></param>
        /// <param name="searchValue"></param>
        /// <returns>least index where holds required number or -1 in case when the is absent </returns>
        public static int BinarySearch(List<int> list, int searchValue)
        {
            return BinarySearch(list, searchValue, 0, list.Count - 1);
        }

        private static int BinarySearch (List<int> list, int searchValue, int lowerBound, int upperBound)
        {           
            int targetItemIndex;
            int indexOfItemToCompare = (int)((upperBound + lowerBound) / 2.0);           
            if (list[indexOfItemToCompare] == searchValue)
            {                
                targetItemIndex = indexOfItemToCompare;
                while ( targetItemIndex > 0 && list[targetItemIndex-1] == searchValue)
                {
                    targetItemIndex--;                    
                }
               
                return targetItemIndex;
            }
            else if (lowerBound >= upperBound)
            {               
                return -1;
            }
            else
            {
                if (list[indexOfItemToCompare] > searchValue)
                {
                    return BinarySearch(list, searchValue, lowerBound, indexOfItemToCompare - 1);
                }
                else
                {
                    return BinarySearch(list, searchValue, indexOfItemToCompare + 1, upperBound);
                }
                                
            }
            
        }

    }
}
