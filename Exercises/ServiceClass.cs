using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public static class ServiceClass
    {

        public static int InputExerciseNumber()
        {
            string inviteMesssage = "\nEnter Exercise number from the number 4 (4, 5, 6, etc.) and press \"Enter\"\n";
            string errorMessage = "\nError! Inputed data is incorrect. It must be integer  positive number from 4 to n. Try again";
            Console.ForegroundColor = ConsoleColor.Green;
            int chosenExerciseNumber = AskUserInputWithValidation(InputIsCorrectExerciseNumber, inviteMesssage, errorMessage);
            Console.ResetColor();
            return chosenExerciseNumber;
        }


        public static int InputPositiveIntegerNumber(string inviteMessage = "\nEnter some arbitary integer positive number and press \"Enter\"")
        {            
            string errorMessage = "\nError! Entered data is incorrect. Try again";
            return AskUserInputWithValidation(InputIsPositiveNumber, inviteMessage, errorMessage);
        }

        public static int InputAnyIntegerNumber(string inviteMessage = "\nEnter some integer number")
        {
            string errorMessage = "\nError! Data that you've inputed is not an integer number. Try again";
            return AskUserInputWithValidation(MockUpValidation, inviteMessage, errorMessage);
        }

        public static int InputNumberBaseNumber()
        {
            string inviteMessage = "\nTo set number base enter some integer number from 2 to 10";
            string errorMessage = "\nError! Input is out of range of valid values. Try again";
            return AskUserInputWithValidation(InputIsCorrectNumberBase, inviteMessage, errorMessage);
        }



        private static int AskUserInputWithValidation(Func<int, bool> validate, string inviteMessage, string errorMessage)
        {
            bool isNumberOk;
            int parsedNumber;
            do
            {
                // Invite for input (parameter 1 str)
                Console.WriteLine(inviteMessage);
                // Get input
                string input = Console.ReadLine();
                // Try to parse input data
                bool isParsingOk = int.TryParse(input, out parsedNumber);
                // Валидация введенного значения
                isNumberOk = isParsingOk && validate(parsedNumber);
                if (!isNumberOk)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(errorMessage);
                    Console.ResetColor();
                }

            }
            while (!isNumberOk);

            return parsedNumber;
        }

        

        public static bool InputIsPositiveNumber(int inputNumber)
        {
            return inputNumber > 0;
        }
        

        public static bool InputIsCorrectExerciseNumber(int inputNumber)
        {
            return inputNumber >= 4;
        }
        
        public static bool MockUpValidation (int inputNumber)
        {
            return true;
        }

        public static bool InputIsCorrectNumberBase(int inputNumber)
        {
            return inputNumber > 1 && inputNumber < 11;
        }        
                
    }
}
