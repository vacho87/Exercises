using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise8 : Exercise
    {

        /// <task_description>
        /// 8.	Write a program that prints all prime numbers. 
        /// (Note: if your programming language does not support arbitrary size numbers,
        /// printing all primes up to the largest number you can easily represent is fine too.)
        /// </task_description>
        public override void ExerciseRun()
        {
            for (ulong i=1; i< 18446744073709551615; i++ )
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }

            bool IsPrime (ulong u)
            {

                bool isprime = true;
                for (ulong i=2;i<u; i++)
                {
                    if (u % i == 0)
                    {
                        isprime = false;
                        break;
                    }    
                        
                }

                return isprime;
            }




        }
    }
}
