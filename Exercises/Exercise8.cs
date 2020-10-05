using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise8 : Exercise
    {
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
