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
            for (long i=1; i< 184467440737091615; i++ )
            {
                if (IsPrime(i)) Console.WriteLine(i);
            }

            bool IsPrime (long u)
            {

                bool isprime = true;
                for (long i=2;i<u; i++)
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
