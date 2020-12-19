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

    public class Exercise217 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("This programm will decompose arbitary integer number that you will enter" +
                "and then will sort it by five various methods");
            List<int> list = Exercise214.DecomposeNumber(ServiceClass.InputAnyIntegerNumber());
            list.ShowList();

            List<int> sortedBySelectionList = SortBySelection(list);
            Console.Write("\nAfter sortig with Selection sort");
            sortedBySelectionList.ShowList();

            List<int> sortedByInsertionList = SortByInsertion(list);
            Console.Write("\nAfter sortig with Insertion sort");
            sortedByInsertionList.ShowList();

            List<int> sortedByMergeList = SortByMerge(list);
            Console.Write("\nAfter sortig with Merge sort    ");
            sortedByMergeList.ShowList();

            List<int> sortedByStoogeList = new List<int>(list);
            StoogeSort(sortedByStoogeList);
            Console.Write("\nAfter sortig with Stooge sort   ");
            sortedByStoogeList.ShowList();

            List<int> sortedByQSortList = new List<int>(list);
            SortByQSort(sortedByQSortList);
            Console.Write("\nAfter sortig with Quick sort    ");
            sortedByQSortList.ShowList();
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



        public static void StoogeSort(List<int> list)
        {
            StoogeAlgorithm(list, 0, list.Count - 1);
        }

        private static void StoogeAlgorithm(List<int> list, int lowerBound, int upperBound)
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
                int firstTwoThirdUpperBound = (upperBound - (currentRangeSize) / 3);

                int secondTwoThirdLowerBound = (lowerBound + (currentRangeSize) / 3);
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


        public static void SortByQSort (List<int> list)
        {
            QSort(list, 0, list.Count - 1);
        }


        private static void QSort(List<int> list, int lowerBound, int upperBound)
        {           
            if (lowerBound >= upperBound)
            {
                return;
            }

            int supportItemIndex = DetectSupportItemPosition(list, lowerBound, upperBound);
            int supportItemValue = list[supportItemIndex];
            int initialSupportItemIndex = supportItemIndex;

            // move list items from left subList to right            
            {
                for (int i = supportItemIndex - 1; i >= lowerBound; i--)
                {
                    if (list[i] > supportItemValue)
                    {
                        list.Insert(supportItemIndex+1, list[i]);
                        list.RemoveAt(i);
                        supportItemIndex--;                       
                    }

                }
               
            }

            int supportItemIndexMovesCount = supportItemIndex - initialSupportItemIndex;

            // move list items from right subList to left 
            for (int i = upperBound; i > supportItemIndex - supportItemIndexMovesCount; i--)
            {
                if (supportItemIndex >= upperBound)
                {
                    return;
                }
                if (list[i] <= supportItemValue)
                {
                    list.Insert(supportItemIndex, list[i]);
                    list.RemoveAt(i + 1);
                    supportItemIndex++;
                    i++;                    
                }
            }
           
            int leftLength = supportItemIndex - lowerBound;
            int rightLength = upperBound - supportItemIndex;

            // С целью предотвращения переполненния стека при сортировке большого массива значений
            // и неравномерном количественном распределении элементов справа и слева от опорного элемента
            // рекурсивный вызов в первую очередь отрабатывает меньший из двух подмассивов 
            if (leftLength < rightLength)
            {                
                QSort(list, lowerBound, supportItemIndex - 1);
                QSort(list, supportItemIndex + 1, upperBound);
            }
            else
            {
                QSort(list, supportItemIndex + 1, upperBound);
                QSort(list, lowerBound, supportItemIndex - 1);
            }
           
        }


        public static int DetectSupportItemPosition(List<int> list, int firstItemIndex, int lastItemIndex)
        {
            if ((lastItemIndex - firstItemIndex + 1) < 4)
            {
                return firstItemIndex;
            }
            else
            {                                
                int middleItemIndex = (lastItemIndex + firstItemIndex) / 2;
                int averageValue = (list[firstItemIndex] + list[lastItemIndex] + list[middleItemIndex]) / 3;

                int firstToAverageDifference = (int)Math.Abs(averageValue - list[firstItemIndex]);
                int lastToAverageDifference = (int)Math.Abs(averageValue - list[lastItemIndex]);
                int middleToAverageDifference = (int)Math.Abs(averageValue - list[middleItemIndex]);               

                if (middleToAverageDifference <= firstToAverageDifference && middleToAverageDifference <= lastToAverageDifference)
                {
                    return middleItemIndex;
                }
                else if (firstToAverageDifference <= middleToAverageDifference && firstToAverageDifference <= lastToAverageDifference)
                {
                    return firstItemIndex;
                }
                else
                {
                    return lastItemIndex;
                }

            }

        }
        
    }

}
