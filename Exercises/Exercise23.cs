using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    ///3.	Write a function that checks whether an element occurs in a list.
    /// </task_description>
    public class Exercise23 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            Exercise22.ShowList(list);
            Console.WriteLine();

            if (ContainsElement(list, 3)) Console.WriteLine("Element \"3\" occures in list. \n");
            else Console.WriteLine("Element \"3\" is absent in list\n");


            if (ContainsElement(list, 11)) Console.WriteLine("Element \"11\" occures in list.\n");
            else Console.WriteLine("Element \"11\" is not occures in list\n");

            // native method applied 
            if (list.Contains(5)) Console.WriteLine("Native method \" list.Contains\" defines that element \"5\" occures in list\n");
            else Console.WriteLine("Native method \" list.Contains\" defined that element \"5\" is not occures in list\n");

        }
        public static bool ContainsElement (List <int> list, int requiredElement)
        {
            foreach (int i in list)
                if (i == requiredElement) return true;
            return false;
        }

    }
}
