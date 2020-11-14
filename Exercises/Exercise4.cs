using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    /// 4. Write a program that asks the user for a number n and prints
    /// the sum of the numbers 1 to n
    /// </task_description>
    class Exercise4 : Exercise
    {
        public override void ExerciseRun()
        {
            ulong sum = 0;
            uint number = ServiceClass.InputPositiveIntegerNumber();

            for (uint i = number; i > 0; i--)
            {
                sum += i;
            }
            Console.WriteLine($"sum of numbers from 1 to {number} (calculated by cycle) = {sum}");


           
            ulong Factorial(uint num)
            {                          // не могу понять почему не получается перехватить исключение на этой строке                
                try
                {
                    if (num == 1) return 1;
                    sum = num + Factorial(num - 1);
                    return sum;
                }
                catch (StackOverflowException)
                {
                    Console.WriteLine($"Recursive method of calculating of sum from 1 to {number} failed, supposedly becase of StackOverflow EXEPTION");
                    return 0;
                }
                
            }

            try
            {
                Console.WriteLine($"sum of numbers from 1 to {number} (calculated by recursion) = {Factorial(number)}");
            }
            catch (StackOverflowException)
            {
                Console.WriteLine($"Recursive method of calculating of sum from 1 to {number} failed, supposedly becase of StackOverflow EXEPTION");

            }


        }
    }
}

