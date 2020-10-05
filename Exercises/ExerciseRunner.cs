using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ExerciseRunner
    {
        public void Run ()
        {
            string choice = $"Exercises.Exercise{ExerciseChooser.AskChoice()}";
            System.Runtime.Remoting.ObjectHandle oh;
            try
            {
                oh = Activator.CreateInstance("Exercises", choice);
                var Ex = (Exercise)oh.Unwrap();
                Ex.ExerciseRun();
            }
            catch
            {
                Console.WriteLine($"Probably exercise with number {ExerciseChooser.number} has not yet been completed." +
                    $"\n Let's try again. Please, enter another number more than 3, but less than  {ExerciseChooser.number}");
                Run();
            }
           
            
        }
        
    }
}
