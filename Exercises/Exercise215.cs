using System;
using System.Collections.Generic;

namespace Exercises
{
    /// <task_description>
    /// 15.	Write functions that add, subtract, and multiply two numbers
    /// in their digit-list representation (and return a new digit list).
    /// If you’re ambitious you can implement Karatsuba multiplication. 
    /// Try different bases. What is the best base if you care about speed?
    /// If you couldn’t completely solve the prime number exercise above due 
    /// to the lack of large numbers in your language, you can now use your own library for this task.
    /// </task_description>
    public class Exercise215 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("\nThis programm will decompose two integer numbers to it's digits and then\n" +
                 "will add, subtract and multiply them in digit-by-digit mode");

            Console.WriteLine("Enter the first number");
            int firstNumber = ServiceClass.InputAnyIntegerNumber();
            int secondNumber = ServiceClass.InputAnyIntegerNumber();
            List<int> decomposedFirstNumber = Exercise214.DecomposeNumber(firstNumber);
            List<int> decomposedSecondNumber = Exercise214.DecomposeNumber(secondNumber);

            Console.WriteLine();
            decomposedFirstNumber.ShowList("decomposedFirstNumber");
            decomposedSecondNumber.ShowList("decomposedSecondNumber");
            Console.WriteLine();

            List<int> SUM = AddTwoNumbersDigits(decomposedFirstNumber, decomposedSecondNumber);
            SUM.ShowList("RESULT OF ADDITION");
            decomposedFirstNumber.ShowList("decomposedFirstNumber");
            decomposedSecondNumber.ShowList("decomposedSecondNumber");
            Console.WriteLine();

            List<int> PROD = MultiplyTwoNumbersDigits(decomposedFirstNumber, decomposedSecondNumber);
            PROD.ShowList("RESULT OF MULTIPLYING");
            decomposedFirstNumber.ShowList("decomposedFirstNumber");
            decomposedSecondNumber.ShowList("decomposedSecondNumber");
            Console.WriteLine();

            List<int> SUBTR = SubtractTwoNumbersDigits(decomposedFirstNumber, decomposedSecondNumber);
            SUBTR.ShowList("RESULT OF SUBTRACTION");
            decomposedFirstNumber.ShowList("decomposedFirstNumber");
            decomposedSecondNumber.ShowList("decomposedSecondNumber");
            Console.WriteLine();
        }



        public static List<int> AddTwoNumbersDigits(List<int> addend1Digits, List<int> addend2Digits)
        {
            List<int> sumDigits;

            if (IsNumberInListPositive(addend1Digits) && IsNumberInListPositive(addend2Digits))
            {
                sumDigits = AddTwoPositiveNumbersDigits(addend1Digits, addend2Digits);
            }

            else if (IsNumberInListPositive(addend1Digits))
            {
                addend2Digits = GetListWithChangedSign(addend2Digits);
                sumDigits = SubtractTwoPositiveNumbersDigits(addend1Digits, addend2Digits);
            }
            else if (IsNumberInListPositive(addend2Digits))
            {
                addend1Digits = GetListWithChangedSign(addend1Digits);
                sumDigits = SubtractTwoPositiveNumbersDigits(addend2Digits, addend1Digits);
            }
            else
            {
                addend1Digits = GetListWithChangedSign(addend1Digits);
                addend2Digits = GetListWithChangedSign(addend2Digits);
                sumDigits = AddTwoPositiveNumbersDigits(addend1Digits, addend2Digits);
                sumDigits = GetListWithChangedSign(sumDigits);
            }

            return sumDigits;
        }


        public static List<int> MultiplyTwoNumbersDigits(List<int> factor1Digits, List<int> factor2Digits)
        {
            factor1Digits.Reverse();
            factor2Digits.Reverse();
            List<int> productDigits = new List<int>();
            int nextDigitIncrement = 0;
            int currentDigitInIntermediateResultList;
            for (int i = 0; i < factor1Digits.Count; i++)
            {
                List<int> intermediateResultDigits = new List<int>();
                for (int k = 0; k < factor2Digits.Count; k++)
                {
                    currentDigitInIntermediateResultList = (factor1Digits[i] * factor2Digits[k]) % 10 + nextDigitIncrement;
                    nextDigitIncrement = factor1Digits[i] * factor2Digits[k] / 10;
                    intermediateResultDigits.Add(currentDigitInIntermediateResultList);
                }

                if (nextDigitIncrement != 0)
                {
                    intermediateResultDigits.Add(nextDigitIncrement);
                }

                nextDigitIncrement = 0;
                intermediateResultDigits.Reverse();
                for (int j = i; j > 0; j--)
                {
                    intermediateResultDigits.Add(0);
                }

                productDigits = AddTwoPositiveNumbersDigits(productDigits, intermediateResultDigits);

            }

            factor1Digits.Reverse();
            factor2Digits.Reverse();
            return productDigits;
        }


        public static List<int> SubtractTwoNumbersDigits(List<int> minuendDigits, List<int> subtrahendDigits)
        {
            List<int> remainderList;

            if (IsNumberInListPositive(minuendDigits) && IsNumberInListPositive(subtrahendDigits))
            {
                remainderList = SubtractTwoPositiveNumbersDigits(minuendDigits, subtrahendDigits);
            }
            else if (IsNumberInListPositive(minuendDigits))  // subtracting negative from positive as addition of two positives ('x' - '-y' = 'x' + 'y')
            {
                remainderList = AddTwoPositiveNumbersDigits(minuendDigits, GetListWithChangedSign(subtrahendDigits));
            }
            else if (IsNumberInListPositive(subtrahendDigits))
            {
                // subtracting positive from negative as the sum of two positives with changed sign
                // '-x' - 'y' = -1 * ('x' + 'y')
                minuendDigits = GetListWithChangedSign(minuendDigits);
                remainderList = AddTwoPositiveNumbersDigits(minuendDigits, subtrahendDigits);
                remainderList = GetListWithChangedSign(remainderList);
            }
            else
            {
                // subtracting negative from negative by reversing the minuend and the subtrahend both with changed sign
                // '-x' - '-y' = 'y' - 'x'
                minuendDigits = GetListWithChangedSign(minuendDigits);
                subtrahendDigits = GetListWithChangedSign(subtrahendDigits);
                remainderList = SubtractTwoPositiveNumbersDigits(subtrahendDigits, minuendDigits);
            }

            return remainderList;
        }


        /// <summary>
        /// Use only(!) for addition of two not negative numbers in list-representation
        /// </summary>
        /// <param name="positiveAddend1Digits"></param>
        /// <param name="positiveAddend2Digits"></param>
        /// <returns>List of integers that contains sum of addend1Digits and addend2Digits</returns>
        public static List<int> AddTwoPositiveNumbersDigits(List<int> positiveAddend1Digits, List<int> positiveAddend2Digits)
        {
            positiveAddend1Digits = new List<int>(positiveAddend1Digits); // For saving argument back to it's initial state
            positiveAddend2Digits = new List<int>(positiveAddend2Digits); // For saving argument back to it's initial state
            EqualizeNUmberOfDigitsInTwoDigitsLists(positiveAddend1Digits, positiveAddend2Digits);
            positiveAddend1Digits.Reverse();
            positiveAddend2Digits.Reverse();

            List<int> sumDigits = new List<int>();
            int nextDigitIncrement = 0;
            int currentDigitInResultList;


            for (int i = 0; i < positiveAddend1Digits.Count; i++)
            {
                currentDigitInResultList = (positiveAddend1Digits[i] + positiveAddend2Digits[i] + nextDigitIncrement) % 10;
                nextDigitIncrement = (positiveAddend1Digits[i] + positiveAddend2Digits[i] + nextDigitIncrement) / 10;
                sumDigits.Add(currentDigitInResultList);
            }

            if (nextDigitIncrement != 0)
            {
                sumDigits.Add(nextDigitIncrement);
            }
                        
            PrepareResultListOfDigitsToReturn(sumDigits);
            return sumDigits;
        }


        /// <summary>
        /// Сomputes the difference between two numbers in thier list-representation
        /// (!)in case of both numbers are positive 
        /// </summary>
        /// <param name="positiveMinuendDigits"></param>
        /// <param name="positiveSubtrahendDigits"></param>
        public static List<int> SubtractTwoPositiveNumbersDigits(List<int> positiveMinuendDigits, List<int> positiveSubtrahendDigits)
        {
            positiveMinuendDigits = new List<int>(positiveMinuendDigits); // To save the argument in it's initial state
            positiveSubtrahendDigits = new List<int>(positiveSubtrahendDigits); // To save the argument in it's initial state 
            bool minuendDigitsWasSmaller = false;

            // Subtracting larger number from smaller by REVERSING and then changing sign of the remainder
            if (positiveMinuendDigits.IsSmallerThan(positiveSubtrahendDigits))
            {
                var transferVariable = positiveMinuendDigits;
                positiveMinuendDigits = positiveSubtrahendDigits;
                positiveSubtrahendDigits = transferVariable;
                minuendDigitsWasSmaller = true;
            }

            positiveMinuendDigits.Reverse();
            positiveSubtrahendDigits.Reverse();
            List<int> remainderDigits = new List<int>();
            int currentDigitInRemainderList;

            for (int i = 0; i < positiveSubtrahendDigits.Count; i++)
            {
                if (positiveMinuendDigits[i] < positiveSubtrahendDigits[i])
                {
                    currentDigitInRemainderList = (positiveMinuendDigits[i] + 10 - positiveSubtrahendDigits[i]);
                    positiveMinuendDigits[i + 1] -= 1;
                }
                else
                {
                    currentDigitInRemainderList = (positiveMinuendDigits[i] - positiveSubtrahendDigits[i]);
                }
                remainderDigits.Add(currentDigitInRemainderList);
            }

            // add to the list, that contains the difference, higher digits of minuend number
            // that were not subtracted because of the subtrahend had fewer digits                     
            remainderDigits.AddRange(positiveMinuendDigits.GetRange(positiveSubtrahendDigits.Count, positiveMinuendDigits.Count - positiveSubtrahendDigits.Count));

            if (minuendDigitsWasSmaller)  // Subtracting larger number from smaller by reversing and then CHANGING SIGN of the remainder
            {
                remainderDigits = GetListWithChangedSign(remainderDigits);
            }

            PrepareResultListOfDigitsToReturn(remainderDigits);
            return remainderDigits;
        }


        public static bool IsNumberInListPositive(List<int> list)
        {            
            return  list[0] > 0;            
        }


        public static List<int> GetListWithChangedSign(List<int> list)
        {
            List<int> resultList = new List<int>(list);
            for (int i = 0; i < resultList.Count; i++)
            {
                resultList[i] *= -1;
            }

            return resultList;
        }


        public static bool OnlyOneListContainsPositiveNUmber(List<int> list1, List<int> list2)
        {
            if (!IsNumberInListPositive(list1) && IsNumberInListPositive(list2))
            {
                return true;
            }
            
            if (IsNumberInListPositive(list1) && !IsNumberInListPositive(list2))
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        public static void EqualizeNUmberOfDigitsInTwoDigitsLists(List<int> list1, List<int> list2)
        {
            int difference = list1.Count - list2.Count;
            if (difference < 0)
            {
                for (int i = difference; i < 0; i++)
                {
                    list1.Insert(0, 0);
                }

            }

            if (difference > 0)
            {
                for (int i = difference; i > 0; i--)
                {
                    list2.Insert(0, 0);
                }

            }
                        
        }


        public static void PrepareResultListOfDigitsToReturn(List<int> resultList)
        {
            resultList.Reverse();
            // remove redundant nulls, remained after higher digits,
            // when the result of the operation between higher duguts is null (0, 0, 0, 4  =>  4)
            while (resultList.Count > 1 && resultList[0] == 0)
            {
                resultList.Remove(0);
            }

        }
    }
}
