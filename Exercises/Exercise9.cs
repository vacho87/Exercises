using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Exercise9 : Exercise
    {
        /// <task_description>
        /// 9.	Write a guessing game where the user has to guess a secret number.
        /// After every guess the program tells the user whether their number was too large
        /// or too small. At the end the number of tries needed should be printed. 
        /// It counts only as one try if they input the same number multiple times consecutively.
        /// </task_description>

        public override void ExerciseRun()
        {
            Console.WriteLine("!!!LET'S PLAY A GAME!!!");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("I will thought of an arbitary positive integer number, and you must guess it.");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine("PRESS ANY KEY");
            Console.ReadKey();
            StartGame();
        }
        void StartGame ()
        {
            for(int i=0;i<18;i++)
            {
                Console.Write("* ");
                int delay = 500 - (i * 30)+20;
                if (delay < 0) delay = 0;
                System.Threading.Thread.Sleep(delay);
            }
            Console.WriteLine("\nI've just thought a number. What the number is?\n" +
                "Input your guess and press \"Enter\"");
            var rnd = new Random();
            int thoughtNumber = rnd.Next(1, 100);
            int guessNumber = (int) NumberInput.Input();
            int previousGuessNumber;
            int tryCounter = 1;
            while (guessNumber!=thoughtNumber)
            {
                previousGuessNumber = guessNumber;
                if (guessNumber < thoughtNumber) Console.WriteLine("Your number is TOO SMALL");
                else Console.WriteLine("Your number is TOO LARGE");
                guessNumber = (int) NumberInput.Input();
                if (previousGuessNumber != guessNumber) tryCounter++;
            }
            Console.WriteLine("!!!CONGRATULATIONS, YOU WON!!!\n" +
                $"The number is {thoughtNumber}. You've done it in {tryCounter} tries!\n\n");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("Want to play one more time? >>> press SPACE-key\n" +
                "For escape press any other key\n");

            if (Console.ReadKey(true).KeyChar == ' ') StartGame(); 

        }

    }
}
