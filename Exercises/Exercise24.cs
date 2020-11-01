using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 4.	Write a function that returns the elements on odd positions in a list.
    /// </task_description>
    public class Exercise24 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> sourceList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The source list looks like that:\n");
            Exercise22.ShowList(sourceList);

            List<int> resultList = ReturnElementsOnOddPosition(sourceList);
            Console.WriteLine("The result list, that contains members of source list that hold on odd positions:\n");
            Exercise22.ShowList(resultList);
        }
        public static List <int> ReturnElementsOnOddPosition (List<int> sourceList)
        {
            List<int> resultList = new List<int>();
            for (int i =0; i<sourceList.Count; i+=2)
            {
                resultList.Add(sourceList[i]);
            }
            return resultList;
        }

    }
}
