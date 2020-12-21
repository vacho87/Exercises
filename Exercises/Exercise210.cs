using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 10.	Write a function that combines two lists by
    /// alternatingly taking elements, e.g. [a,b,c],[1,2,3] → [a,1,b,2,c,3].
    /// </task_description>
    public class Exercise210 : Exercise
    {
        public override void ExerciseRun()
        {
            List<object> list1 = new List<object> { 1, 2, 3, 4, 5};
            List<object> list2 = new List<object> { "a", "b", "c", "d", "e" };
            var mixedList = MixTwoLists(list1, list2);
            Exercise22.ShowList(list1, "\"list1\"");
            Exercise22.ShowList(list2, "\"list2\"");
            Exercise22.ShowList(mixedList, "\"mixedList\"");
        }

        public static List <object> MixTwoLists (List<object> list1, List <object> list2)
        {
            List<object> mixedList = new List<object>();
            
            int smallerListCount = list1.Count < list2.Count ? list1.Count : list2.Count; // Попробовал сделать меньше слов
            int largerListCount = smallerListCount == list1.Count ? list2.Count : list1.Count; // Попробовал сделать меньше слов
            var largerList = largerListCount==list1.Count ? list1 : list2; // Попробовал сделать меньше слов
            for (int i=0; i<smallerListCount; i++)
            {
                mixedList.Add(list1[i]);
                mixedList.Add(list2[i]);
            }
            for (int i = smallerListCount; i<largerListCount; i++)
            {
                mixedList.Add(largerList[i]);
            }
            return mixedList;
        }

         
    }
}
