using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <task_description>
    ///6.	Write a function that tests whether a string is a palindrome.
    /// </task_description>
    public class Exercise26 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("Enter some string to check whether inputed string is a palindrome");
            string input = Console.ReadLine();
            Console.WriteLine();
            if (IsAStringAPalindrome(input))
                Console.WriteLine($"String \"{input}\" is a palindrome\n");
            else Console.WriteLine($"String \"{input}\" is not a palindrome\n");           
        }

        public static bool IsAStringAPalindrome (string str)
        {
            char[] splittedString = str.ToCharArray();
            int firstHalfPointer;
            int secondHalfPointer;
            if (splittedString.Length%2==0)
            {
                secondHalfPointer = splittedString.Length / 2;
                firstHalfPointer = secondHalfPointer - 1;
            }
            else
            {
                firstHalfPointer = splittedString.Length / 2 -1;
                secondHalfPointer = firstHalfPointer + 2;
            }
            for (; secondHalfPointer<splittedString.Length; firstHalfPointer--, secondHalfPointer++)
            {
                if (splittedString[firstHalfPointer] != splittedString[secondHalfPointer]) return false;
            }
            return true;
        }
    }
}
