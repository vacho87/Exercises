using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    /// <summary>
    /// <task_description>
    /// 26.	Write function that translates a text to Pig Latin and back.
    /// English is translated to Pig Latin by taking the first letter
    /// of every word, moving it to the end of the word and adding ‘ay’.
    /// “The quick brown fox” becomes “Hetay uickqay rownbay oxfay”.
    /// </task_description>
    /// </summary>
    public class Exercise220 : Exercise
    {
        public override void ExerciseRun()
        {
            Console.WriteLine("Please, type any text and press \"Enter\". The text will be translated to Pig Latin");
            string text = Console.ReadLine();
            string translatedText = TranslateTextToPigLatin(text);
            Console.WriteLine(translatedText);
        }
        
        public static string TranslateTextToPigLatin(string text)
        {
            List<string> words = text.Split(' ').ToList() ;
            for (int i = 0; i < words.Count; i++)
            {               
                words[i] = TranslateWordToPigLatin(words[i]);
            }

            string translatedText = "";
            foreach (string word in words)
            {
                translatedText += word;
            }
            return translatedText.Remove(0, 1);
        }


        public static string TranslateWordToPigLatin(string word)
        {
            
           List<char> letters =  word.ToList();

            if (letters.Count ==1 && Char.IsPunctuation(letters[0]))
            {
                word = " " + word;
                return word;
            }
            
            if ( Char.IsUpper(letters[0]))
            {
                letters.Add(Char.ToLower(letters[0]));
                letters.RemoveAt(0);
                letters[0] = Char.ToUpper(letters[0]);                
            }
            else
            {
                letters.Add((letters[0]));
                letters.RemoveAt(0);                      
            }

            string translatedWord = " ";
            foreach (char letter in letters)
            {                
                translatedWord += letter.ToString();
            }

            translatedWord += "ay";
            return translatedWord;
        }

    }

}
