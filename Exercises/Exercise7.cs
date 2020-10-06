using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise7 : Exercise
    {
        /// <task_description>
        /// 7.	Write a program that prints a multiplication table for numbers up to 12.
        /// </task_description>

        public override void ExerciseRun ()
        {
            Console.Write("*****HERE IS A MULTIPLICATION TABLE OF NUMBERS FROM 1 TO 12*****\n");

            StringBuilder borderLine = new StringBuilder("\n+-------+");
            for (int i=0;i<12;i++)
            {
                borderLine.Append("---+");
            }
            borderLine.Append("\n");
            Console.Write(borderLine);


            StringBuilder productTable = new StringBuilder("| factor|");
            for (int i = 0; i < 12; i++)
            {
                string multiplierRowCell = $"{i + 1,-3}|";
                productTable.Append(multiplierRowCell);
            }
            productTable.Append(borderLine);
            for (int i=0;i<12;i++)
            {
                string multiplierColumnCell = $"|{i + 1,-7}|";
                productTable.Append(multiplierColumnCell);
                for (int k=0;k<12;k++)
                {
                    string multiplicationResultCell = $"{(i + 1) * (k + 1),-3}|";
                    productTable.Append(multiplicationResultCell);
                }
                productTable.Append(borderLine);
            }

            Console.WriteLine(productTable);
     
        }
    }
}
