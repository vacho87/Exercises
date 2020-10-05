﻿using System;
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
            int sum = 0;
            int number = NumberInput.Input();

            for (int i = number; i > 0; i--)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }
            Console.WriteLine($"sum of numbers from 1 to {number}, such that only multiples of three or five = {sum}");

        }
    }
}