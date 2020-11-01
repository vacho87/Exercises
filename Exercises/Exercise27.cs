using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise27 : Exercise
    {
        // <task_description>
        /// 7.	Write three functions that compute the sum of the numbers in a list:
        /// using a for-loop, a while-loop and recursion.
        /// </task_description>
        public override void ExerciseRun()
        {
            List <int>  list = new List<int> { 1, 2, 3, 4, 5 };
            Exercise22.ShowListOfInt(list);

            Console.WriteLine($"\nThe sum of all elements un list, counted with CountSumWithRecursion metod is {CountSumWithRecursion(list)}");
            Console.WriteLine($"\nThe sum of all elements un list, counted with CountSumWithForCycle metod is {CountSumWithForCycle(list)}");
            Console.WriteLine($"\nThe sum of all elements un list, counted with CountSumWithWhileCycle metod is {CountSumWithWhileCycle(list)}");
        }

        public static int CountSumWithForCycle (List<int> list)
        {
            int result =0;
            for (int i=0; i<list.Count; i++)
            {
                result += list[i];
            }
            return result;
        }
        public static int CountSumWithWhileCycle (List <int> list)
        {
            int result = 0;
            int i = 0;
            while (i<list.Count)
            {
                result += list[i];
                i++;
            }
            return result;
        }
        
        public static int CountSumWithRecursion(List<int> list, int index = 0)
        {
            
            if (index == list.Count - 1)
            {
                return list[index];
            }
            else
            {
              return list[index] + CountSumWithRecursion(list, ++index);
            }
           
        }
    }
}
