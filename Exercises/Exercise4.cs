using System;
using System.Collections.Generic;
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
            int sum = 0;
            int number = NumberInput.Input();

            int Factorial (int num)
            {
                if (num == 1) return 1;
                sum = num + Factorial(num - 1);
                return sum;
            }


            //for (int i = number; i > 0; i--)
            //{
            //    sum += i;
            //}
            Console.WriteLine($"sum of numbers from 1 to {number} = {Factorial(number)}");
        }
    }
}
