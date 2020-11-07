using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    // <task_description>
    /// 13.	Write a function that computes the list of the first 100
    /// Fibonacci numbers. The first two Fibonacci numbers are 1 and 1.
    /// The n+1-st Fibonacci number can be computed by adding the n-th
    /// and the n-1-th Fibonacci number. The first few are therefore
    /// 1, 1, 1+1=2, 1+2=3, 2+3=5, 3+5=8.
    /// </task_description>
    public class Exercise213 : Exercise
    {
        public override void ExerciseRun()
        {
            List<decimal> list = GetFibonachiRow(110);
            Console.WriteLine("The first 100 Fibonachi numbers are:");
            list.ShowList();
        }

        public static List<decimal> GetFibonachiRow(int numberOfLastRowElement)
        {
            List<decimal> fibonachiRow = new List<decimal>(numberOfLastRowElement);
            fibonachiRow.Add(1);

            if (numberOfLastRowElement >= 2)
            {
                fibonachiRow.Add(1);
                for(int i=2; i< numberOfLastRowElement; i++)
                {
                    fibonachiRow.Add(fibonachiRow[i - 1] + fibonachiRow[i - 2]);
                }

            }

            return fibonachiRow;
        }

    }
}
