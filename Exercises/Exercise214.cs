﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{

    /// <task_description>
    /// 14.	Write a function that takes a number and returns a list
    /// of its digits. So for 2342 it should return [2,3,4,2].
    /// </task_description>
    public class Exercise214 : Exercise
    {
        public override void ExerciseRun()
        {
            List<int> list = DecomposeNumber(ServiceClass.InputAnyIntegerNumber());
            Console.WriteLine("The number was decomposed to digits, which were put in list");
            list.ShowList();
        }

        public static List<int> DecomposeNumber(int number)
        {
            if (number == 0)
            {
                return new List<int> { 0 };
            }
            List<int> listOfDigitsOfNumber = new List<int>();
            while (number != 0)
            {
                listOfDigitsOfNumber.Add((number % 10));
                number /= 10;
            }

            listOfDigitsOfNumber.Reverse();
            return listOfDigitsOfNumber;
        }

        /* Была мысль вынести метод в класс-хелпер, сделать его общим для всех упражнений.
        * Но при сравнении подобных "аскеров" в иных упражнениях не выявлено ни одного 
        * абсолютно одинкакового метда. Они все отличаются:
        * - один требует только положительных чисел;
        * - другой требует, чтобы число было не менее четырех;
        * - третий, помимо проверки на число, проверяет еще и наличие введенного числа в списке;
        * - текущий метод требует только чтобы число было целочисленным.        
        * Посему решил оставить этот метод здесь.*/
        
    }
}
