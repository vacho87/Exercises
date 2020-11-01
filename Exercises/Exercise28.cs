using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    // <task_description>
    /// 8.	Write a function on_all that applies a function to
    /// every element of a list. Use it to print the first twenty
    /// perfect squares. The perfect squares can be found by multiplying
    /// each natural number with itself. The first few perfect squares
    /// are 1*1= 1,2*2=4,3*3=9, 4*4=16. Twelve for example is not a perfect
    /// square because there is no natural number m so that m*m=12.
    /// </task_description>
    public class Exercise28 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
            Exercise22.ShowList(list);
            SetDelegateMethod();
            On_All(list, deleg);
        }

        void ReturnPowerofTwo (int number)
        {
            Console.WriteLine($"The square of number {number} is {number * number}");            
        }

        void ReturnPowerofThree (int number)
        {
            Console.WriteLine($"The power of three of number {number} is {Math.Pow(number,3)}");
        }

        delegate void SquareOrCubeDelegate(int number);
        SquareOrCubeDelegate deleg;
        void SetDelegateMethod ()
        {
            int choise = AskChoise();
            switch (choise)
            {
                case 2: deleg = ReturnPowerofTwo;
                    break;
                case 3: deleg = ReturnPowerofThree;
                    break;
                default: Console.WriteLine("You haven't chosen any method to process items in list. The exercise skipped");
                    break;
            }
        }


        int AskChoise ()
        {
            Console.WriteLine("Enter \"2\" to display list items, rised to a power of two\n" +
                              "Enter \"3\" to display list items, rised to a power of three\n" +
                              "To exit enter any other value\n");
            _ = int.TryParse(Console.ReadLine(), out int choise);
            if (choise == 2 || choise == 3) return choise;
            else return 0;
        }
        
        void On_All (List<int> list, SquareOrCubeDelegate @delegate)
        {
            if (@delegate == null) 
                return;
            foreach (int item in list)
                @delegate(item);
        }

    }
}
