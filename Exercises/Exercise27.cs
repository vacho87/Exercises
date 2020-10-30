using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise27 : Exercise
    {
        public override void ExerciseRun()
        {
            List <int>  list = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(CountSummWithRecursion(list));
            Console.WriteLine(CountSummWithForCycle(list));
            Console.WriteLine(CountSummWithWhileCycle(list));


        }

        public int CountSummWithForCycle (List<int> list)
        {
            int result =0;
            for (int i=0; i<list.Count; i++)
            {
                result += list[i];
            }
            return result;
        }
        public int CountSummWithWhileCycle (List <int> list)
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
        int result = 0;
        public int CountSummWithRecursion (List<int> list, int index=0)
        {
            if (index == list.Count - 1)
            {
               return list[index];
            }
            else
            {
                index++;
                result += CountSummWithRecursion(list, index);
            }
            return result;
        }


    }
}
