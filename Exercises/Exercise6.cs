﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise6: Exercise
    {
        /// <task_description>
        /// 6.Write a program that asks the user for a number n and gives them
        /// the possibility to choose between computing the sum and computing
        /// the product of 1,…,n.
        /// </task_description>
        public override void ExerciseRun()
        {
            var choiсe = AskSumOrProduct.Ask();
            int number;
            switch (choiсe)
            {
                case "s":
                    Console.WriteLine($"The sum of the numbers from 1 to {number = NumberInput.Input()} = {Sum(number)}");
                    break;
                case "p":
                   Console.WriteLine($"The product of the numbers from 1 to {number = NumberInput.Input()} = {Product(number)}");
                    break;
                case "e":
                    return;
            }


        }
        int Sum (int number)
        {
            int sum=0;
            for (;number>0;number--)
            {
                sum += number;
            }
           
            return sum ;
        }
        int Product (int number)
        {
            int product = 1;
            for (;number>0;number--)
            {
                product *= number;
            }
            return product;
        }
    }
}
