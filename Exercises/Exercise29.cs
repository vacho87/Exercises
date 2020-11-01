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
            List<int> list1 = new List<int> { 1, 2, 3, 4, 5 };            
            Exercise22.ShowListOfInt(list1, "\"list1\"");

            List<char> list2 = new List<char> { 'a','b','c','d','e' };
            Exercise22.ShowListofChar(list2, "\"list2\"");

            //List<object> concatenatedList = ConcatenateTwoLists(list1, list2);




            throw new NotImplementedException();
        }
        public List <T> ConcatenateTwoLists<T> (List<T> list1, List <T> list2)
        {
            List<T> resultList = new List<T>(list1);
            resultList.AddRange(list2);
            return resultList;            
        }





    }
}
