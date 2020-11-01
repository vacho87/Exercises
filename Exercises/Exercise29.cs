using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    // <task_description>
    /// 9.	Write a function that concatenates two lists. [a,b,c], [1,2,3] → [a,b,c,1,2,3]
    /// </task_description>
    public class Exercise29 : Exercise
    {
        public override void ExerciseRun()
        {
            List<object> list1 = new List<object> { 1, 2, 3, 4, 5 };            
            Exercise22.ShowList(list1, "\"list1\"");

            List<object> list2 = new List<object> { 'a','b','c','d','e' };
            Exercise22.ShowList(list2, "\"list2\"");

            List<object> concatenatedList = ConcatenateTwoLists(list1, list2);
            Exercise22.ShowList(concatenatedList, "\"concatenatedlist\"");
        }
        public static List <object> ConcatenateTwoLists (List<object> list1, List <object> list2)
        {
            List<object> resultList = new List<object>(list1);
            resultList.AddRange(list2);
            return resultList;            
        }





    }
}
