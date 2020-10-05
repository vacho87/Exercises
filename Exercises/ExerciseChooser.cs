﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    static class ExerciseChooser
    {
        public static int number;
        public static int AskChoice ()
        {
            Console.WriteLine("Enter Exercise number from the number 4 (4, 5, 6, etc.) and press \"Enter\"");
            string input = Console.ReadLine();
                   
            while (!InputIsOk(input))
            {
                Console.WriteLine("Error! Inputed data is incorrect. Please, enter some integer positive number from 4 to n");
                input = Console.ReadLine();
            }

            return number;
        }

        static bool InputIsOk(string str)
        {
            if (int.TryParse(str, out int result) & result >= 4)
            {
                number = result;
                return true;
            }
            else return false;
        }

               
        
    }
}
