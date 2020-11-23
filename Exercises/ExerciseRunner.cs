using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class ExerciseRunner
    {
        public void Run()
        {
            string choice = $"Exercises.Exercise{ServiceClass.InputExerciseNumber()}";
            System.Runtime.Remoting.ObjectHandle oh;
            try
            {
                oh = Activator.CreateInstance("Exercises", choice);
                var Ex = (Exercise)oh.Unwrap();
                 Ex.ExerciseRun();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"\nProbably exercise with number {ServiceClass.InputExerciseNumber()} has not yet been completed." +
                    $"\nLet's try again. Please, enter another number more than 3, but less than  {ServiceClass.InputExerciseNumber()}");
                Console.ResetColor();
                Run();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nFor escape  press key \"e\"\n" +
                "If you want to run one more exercise press any other key");
            Console.ResetColor();

            if (Console.ReadKey(true).KeyChar != 'e') Run();

        }

    }
}
