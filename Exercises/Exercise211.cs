using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 11.	Write a function that merges two sorted lists into 
    /// a new sorted list. [1,4,6],[2,3,5] → [1,2,3,4,5,6]. 
    /// You can do this quicker than concatenating them followed by a sort.
    /// </task_description>
    public class Exercise211 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list1 = new List<int> { 1, 1, 4, 5, 9};
            List<int> list2 = new List<int> { 4, 4, 6, 7, 102 };
            list1.ShowList("list1");
            list2.ShowList("list2");

            List<int> resultList = MergeTwoSortedLists(list1, list2);
            Console.WriteLine("\nAfter merging\n");
            resultList.ShowList("resultList");
        }

        /*
         * "Methods should not exceed 7 statements"- одна из рекомендаций в CodeGuideLinesCheetSheet 
         * как не пытался, не смог придумать метод, чтоб он хоть немного приблизился к этой рекомендации:
         * во-первых я не смог придумать иной более эффективный алгоритм слияния отсортированных списков, 
         * который сам по себе был бы лаконичнее;
         * во-вторых принятый мной алгоритм я не смог упростить путем выделения подметодов.
         * 
         * Поискал на этот счет информацию в интернете, увидел что мнения разделяются.
         * Мне показалось интересным мнение одного товарища на хабре https://habr.com/ru/post/239799/ 
         * Хотелось бы услышать хоть вкратце твое мнение насчет необходимости возможности "непревышения" размера в 7 выражений в методе
         * 
         * Еще интересно какой алгоритм для этой задачи применил бы ты
        */
        public static List<int> MergeTwoSortedLists(List<int> list1, List<int> list2)
        {
            List<int> resultList = new List<int>(list1.Count+list2.Count);
            int list1Pointer = 0;
            int list2Pointer = 0;

            while (list1Pointer < list1.Count && list2Pointer < list2.Count)
            {
                if (list1[list1Pointer] < list2[list2Pointer])
                {
                    resultList.Add(list1[list1Pointer]);
                    list1Pointer++;
                }
                else
                {
                    resultList.Add(list2[list2Pointer]);
                    list2Pointer++;
                }
            }

            if (list1Pointer < list1.Count)
            {
                resultList.AddRange(list1.GetRange(list1Pointer, list1.Count - list1Pointer));
            }
            else
            {
                resultList.AddRange(list2.GetRange(list2Pointer, list2.Count - list2Pointer));
            }

            return resultList;
        }
    }
}
