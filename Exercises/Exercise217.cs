using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <summary>
    /// <task_description>
    /// 17. Implement the following sorting algorithms:
    /// Selection sort, Insertion sort, Merge sort, Quick sort, Stooge Sort.
    /// Check Wikipedia for descriptions.
    /// </task_description>
    /// </summary>

    class Exercise217 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("This programm will decompose arbitary integer number that you will enter" +
                "and then will sort it by five various methods");
            List<int> list = Exercise214.DecomposeNumber(ServiceClass.InputAnyIntegerNumber());
            list.ShowList();

            List<int> sortedBySelectionList = SortBySelection(list);
            Console.WriteLine("After sortig with Selection sort");
            sortedBySelectionList.ShowList();

            List<int> sortedByInsertionList = SortByInsertion(list);
            Console.WriteLine("After sortig with Insertion sort");
            sortedByInsertionList.ShowList();

            List<int> sortedByMergeList = SortByMerge(list);
            Console.WriteLine("After sortig with Merge sort");
            sortedByMergeList.ShowList();

            List<int> sortedByStoogeList = new List<int>(list);
            StoogeSort(sortedByStoogeList);
            Console.WriteLine("After sortig with Stooge sort");
            sortedByStoogeList.ShowList();


        }

        public static List<int> SortBySelection(List<int> list)
        {
            List<int> resultList = new List<int>(list);
            int minValueIndex;
            for (int i = 0; i < resultList.Count - 1; i++) // variable 'i' points the first unsorted item in list
            {
                minValueIndex = i; // minValueIndex declared besides 'i' only to make code more readable.
                int transitVariable;

                for (int k = i; k < resultList.Count; k++)
                {
                    if (resultList[k] < resultList[minValueIndex])
                    {
                        minValueIndex = k;
                    }

                }

                transitVariable = resultList[minValueIndex];
                resultList[minValueIndex] = resultList[i];
                resultList[i] = transitVariable;
            }

            return resultList;
        }


        public static List<int> SortByInsertion(List<int> list)
        {
            List<int> resultList = new List<int>(list);
            int lastSortedPointer = 0;
            int firstUnsortedItemPointer = 1;
            int indexOfPositionToInsert;

            for (; firstUnsortedItemPointer < resultList.Count; firstUnsortedItemPointer++)
            {
                indexOfPositionToInsert = 0;
                for (int i = lastSortedPointer; i >= 0; i--)
                {
                    if (resultList[firstUnsortedItemPointer] >= resultList[i])
                    {
                        indexOfPositionToInsert = i + 1;
                        break;
                    }

                }

                resultList.Insert(indexOfPositionToInsert, resultList[firstUnsortedItemPointer]);
                resultList.RemoveAt(firstUnsortedItemPointer + 1);
                lastSortedPointer++;
            }

            return resultList;
        }


        public static List<int> SortByMerge(List<int> list)
        {
            if (list.Count == 1)
            {
                return list;
            }
            else
            {
                List<int> resultList = new List<int>();
                int firstSubListItemsCount = list.Count / 2;
                List<int> firstSubList = new List<int>(list.GetRange(0, firstSubListItemsCount));
                List<int> secondSubList = new List<int>(list.GetRange(firstSubListItemsCount, list.Count - firstSubListItemsCount));
                firstSubList = SortByMerge(firstSubList);
                secondSubList = SortByMerge(secondSubList);

                while (firstSubList.Count > 0 && secondSubList.Count > 0)
                {
                    if (firstSubList[0] <= secondSubList[0])
                    {
                        resultList.Add(firstSubList[0]);
                        firstSubList.RemoveAt(0);
                    }
                    else
                    {
                        resultList.Add(secondSubList[0]);
                        secondSubList.RemoveAt(0);
                    }

                }

                if (firstSubList.Count > 0)
                {
                    resultList.AddRange(firstSubList);
                }
                else
                {
                    resultList.AddRange(secondSubList);
                }

                return resultList;
            }

        }



        // Пришлось вложить метод в метод так как не знал, как еще сообщить методу
        // границы сортируемого диапазона при первом его вызове.
        // Пробовал использовать параметры по умолчанию, но, если определить параметр
        // lowerBound как "int lowerBound = 0" возможно, то определить параметр
        // upperBound как "int upperBound = list.Count - 1" нельзя.
        //
        // !!! Обязательно проверить сортироку массива 4746252 !!!
        // !!! А ТАК ЖЕ 4749252 !!!
        public static void StoogeSort(List<int> list)
        {
            StoogeAlgorithm(list, 0, list.Count - 1);
        }

        public static void StoogeAlgorithm(List<int> list, int lowerBound, int upperBound)
        {
            if (list[lowerBound] > list[upperBound])
            {
                int transferVariable = list[lowerBound];
                list[lowerBound] = list[upperBound];
                list[upperBound] = transferVariable;
            }

            int currentRangeSize = upperBound - lowerBound + 1;
            if (currentRangeSize > 2)
            {
                int firstTwoThirdLowerBound = lowerBound;
                int firstTwoThirdUpperBound = (lowerBound + (currentRangeSize - 1) * 2 / 3);

                int secondTwoThirdLowerBound = (upperBound - (currentRangeSize - 1) * 2 / 3);
                int secondTwoThirdUpperBound = upperBound;

                StoogeAlgorithm(list, firstTwoThirdLowerBound, firstTwoThirdUpperBound);
                StoogeAlgorithm(list, secondTwoThirdLowerBound, secondTwoThirdUpperBound);
                StoogeAlgorithm(list, firstTwoThirdLowerBound, firstTwoThirdUpperBound);

            }
            else
            {
                return;

            }

        }

    }

}
