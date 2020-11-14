using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise5 : Exercise
    {
        /// <task_description>
        /// 5. Modify the previous program such that only multiples of three
        /// or five are considered in the sum, e.g. 3, 5, 6, 9, 10, 12, 15 for n=17
        /// <previous> 4. Write a program that asks the user for a number n and prints
        /// the sum of the numbers 1 to n</previous>
        /// </task_description>
        public override void ExerciseRun()
        {
            ulong sum = 0;
            uint number = ServiceClass.InputPositiveIntegerNumber();

            ulong RestrictedFactorial (uint num)
            {
                if (num == 1) return 0;
                if (num % 3 == 0 || num % 5 == 0)
                    sum = num + RestrictedFactorial(num - 1);
                else sum = RestrictedFactorial(num - 1);
                
                return sum;
            }

            for (uint i = number; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine($"sum of numbers from 1 to {number}, such that only multiples of three or five = {RestrictedFactorial(number)}");

        }
    }
}
