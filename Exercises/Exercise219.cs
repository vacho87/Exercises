using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <summary>
    /// <task_description>
    /// 19.	Write a function that takes a list of strings an prints them, one per line,
    /// in a rectangular frame. For example the list ["Hello", "World", "in", "a", "frame"] gets printed as:
    ///     *********
    ///     * Hello *
    ///     * World *
    ///	    * in    *
    ///	    * a     *
    ///	    * frame *
    ///     *********
    /// </task_description>
    /// </summary>
    public class Exercise219 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("Enter a sentece and it will be printed in frame word by word");
            Console.WriteLine("Enter any string, where words are divided each other by spaces and press \"Enter\"");
            string input = Console.ReadLine();
            List<string> list = new List<string>(input.Split(' '));
            Console.WriteLine("The result looks like: ");
            PrintWordsInFrame(list);
        }


        // Не придумал как протестировать метод
        private void PrintWordsInFrame(List<string> list)
        {
            int longestWordLength = 0;
            
            foreach (string word in list)
            {               
                if (word.Length > longestWordLength)
                {
                    longestWordLength = word.Length;
                }

            }

            StringBuilder borderLine = new StringBuilder();
            borderLine.Append('*', longestWordLength + 4);
            Console.WriteLine(borderLine);
            foreach (string word in list)
            {
                StringBuilder wordString = new StringBuilder("* " + word);
                wordString.Append(' ', longestWordLength - word.Length);
                wordString.Append(" *");
                Console.WriteLine(wordString);
            }

            Console.WriteLine(borderLine);            
        }
       
    }
}
