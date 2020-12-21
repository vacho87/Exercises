using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class Exercise6: Exercise
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
                    Console.WriteLine($"The sum of the numbers from 1 to {number = ServiceClass.InputPositiveIntegerNumber()} = {Sum(number)}");
                    break;
                case "p":
                   Console.WriteLine($"The product of the numbers from 1 to {number = ServiceClass.InputPositiveIntegerNumber()} = {Product(number)}");
                    break;
                case "e":
                    break;
                default:
                    {
                        Console.WriteLine("Data you've inputted is incorrect. Let's try again.");
                        ExerciseRun();
                    }
                    break;
            }


        }
        public long Sum (int number)
        {
            long sum=0;
            for ( ;number>0;number--)
            {
                sum += number;
            }
           
            return sum ;
        }
        public long Product (int number)
        {
            long product = 1;
            for ( ;number>0;number--)
            {
                product *= number;
            }
            return product;
        }
    }
}
