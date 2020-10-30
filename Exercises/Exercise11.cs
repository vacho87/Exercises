using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Exercises.Performance;

namespace Exercises
{
    public class Exercise11 : Exercise
    {
        /// <task_description>
        /// 11.	Write a program that computes the sum of an alternating series
        /// where each element of the series is an expression of the form
        /// ((-1)^(k+1))/(2 * k-1) for each value of k from 1 to a million, multiplied by 4.       
        /// </task_description>


        /// <summary>
        /// Сделал расчет тремя способами, каждый из которых, по моему мнению, должен был считать
        /// быстрее, чем предыдущий. Запустил выполнение для k=1....1 000 000, отработало слишком быстро, 
        /// и я не смог оценить визуально скорость выполнения. Решил увеличить объем вычислений до 100 000 000
        /// операций. Стала заметна задержка, стала очевидна уже и разница во времени исполнения.
        /// Замерил секундомером время исполнения каждого расчета по задержке вывода на консоль (подозреваю, что это 
        /// можно было замерить и средствами диагностики, но я пока не умею)
        /// Результаты испонения:
        /// - первый метод - 34,10 сек.;
        /// - второй метод - 23,45 сек.;
        /// - третий метод - 21,24 сек.
        /// Обратил внимание, что при k=1....1 000 000 результатом является число Пи
        /// </summary>    
        public override void ExerciseRun()
        {
            decimal result=0;
            System.Threading.Thread.Sleep(2500); // поток усыпил для создания задержки начала выполнения расчетов
            // для возможности визуального измерения времени выполнения
            Console.Write("Sum of row of expressions of the form (-1) ^ (k + 1) / (2 * k - 1) \n" +
                          " for k=1 to 100 000 000, calculated by ExpressionValueCalc method: ");
            
            using (new Step($"ExpressionValueCalc for {1000000:N}"))
            {
                for (int k = 1; k <= 1000000; k++)
                {
                    result += ExpressionValueCalc(k);
                }
                Console.WriteLine(result*4);
            }

            result = 0;
            Console.Write("Sum of row of expressions of the form (-1) ^ (k + 1) / (2 * k - 1) \n" +
                          " for k=1 to 100 000 000, calculated by ExpressionValueSmartCalc method: ");
            using (new Step($"ExpressionValueCalc for {1000000:N}"))
            {
                for (int k = 1; k <= 1000000; k++)
                {
                    result += ExpressionValueSmartCalc(k);
                }
                Console.WriteLine(result*4);
            }

            Console.Write("Sum of row of expressions of the form(-1) ^ (k + 1) / (2 * k - 1) \n" +
                          " for k=1 to 1 000 000, calculated by ExpressionValueSmartCalc method: ");
            Console.WriteLine(TheSmartestCalc(1000000));

        }

        public static decimal ExpressionValueCalc (int k)
        {
            decimal expressionValue = (decimal) Math.Pow(-1, (k + 1)) / (2m * k - 1m);
            return expressionValue; 
        }

        public static decimal ExpressionValueSmartCalc (int k)
        {
            decimal expressionValue;
            expressionValue = (k % 2 == 1) ? (1 / (2m * k - 1)) : (-1m / (2 * k - 1));
            return expressionValue;
        }

        public static decimal TheSmartestCalc (int k)
        {
            decimal sumOfExpressionsRow = 0;
            decimal positiveDivisor = 1m;
            decimal negativeDivisor = 3m;
            for (int i = k/2; i>0; i--)
            {
                sumOfExpressionsRow += 1/positiveDivisor - 1/negativeDivisor;
                positiveDivisor += 4;
                negativeDivisor += 4;
            }
            if (k % 2 == 1) sumOfExpressionsRow += 1 / positiveDivisor;

            return sumOfExpressionsRow*4;            
        }


        
    }
}
