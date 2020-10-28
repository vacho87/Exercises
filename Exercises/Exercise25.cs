using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    ///5.	Write a function that computes the running total of a list.
    /// </task_description>
    public class Exercise25 :Exercise 
    {
        public override void ExerciseRun()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            ShowCurrentTotalOfList(list);

            list.Add(19);
            Console.WriteLine("One item was added");
            ShowCurrentTotalOfList(list);

            list.AddRange(new int [] { 2, 3, 4, 55, 6});
            Console.WriteLine("Some array of integers was added to list");
            ShowCurrentTotalOfList(list);                        
        }
        
        public static int ComputeRunningTotalOfList (List <int> list)
        {
            int runningTotal = 0;
            foreach (int i in list) runningTotal++;
            return runningTotal;
        }

        void ShowCurrentTotalOfList (List <int> list)
        {
            Console.WriteLine($"Current total of items in list calculated by custom method " +
                $"\"ComputeRunningTotalOfList\": {ComputeRunningTotalOfList(list)}");
            Console.WriteLine($"Current total of items in list calculated with native method: {list.Count}\n");
        }

    }
}
