using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    
    public static class ListExtension
    {

        // SHOW LIST OF INTEGERS METHODS
        public static void ShowList (this List<int> list, string listName)
        {
            Console.Write ($"{listName} contains: ");

            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");           
        }

        public static void ShowList(this List<int> list)
        {
            Console.Write($"list contains: ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");
        }


        // Таким образом (придумав свой метод со схожим названием) я попытался заменить переопределение метода Equals
        // для объектов типа List<int>. Так и не разобрался с возможностью такого переопределения.
        // Ведь переопределить его в классе List<T> нельзя, так как класс сиситемный. 
        // Сделать это через методы расширения тоже нельзя, так как методы расширения должны быть 
        // статическими, что несовместимо с модификатором override.

        // У меня вопрос: есть ли возможность переопределить метод Equals для стандартных типов, 
        // не выдумывая собственные методы?
        // Ведь, например, для типа List<int> логичнее было бы сравнить содержимое на равенство, 
        // нежели просто выяснить что обе ссылки указывают на один и тот же объект. 
        // Кроме того, для проверки ссылок на идентичность можно использовать непереопределенный
        // оператор ==, а также метод Object.ReferenceEquals.
        // Впринципе я понимаю, почему базовая реализация метода Equals такова. Это единственный 
        // способ сравнения всех объектов, не зная заранее их реализацию (внутреннюю логику, семантику).
        // Но мне кажется неправильным, что его нельзя "довернуть" под себя  или я просто не нашел такой способ.

        public static bool IsEqual (this List<int> list, List<int> listToCompare)
        {
            if (list.Count != listToCompare.Count)
            { 
                return false;
            }
            else
            {
                for (int i = 0; i < list.Count; i++)
                {
                    if (list[i] != listToCompare[i]) 
                        return false;
                }

            }

            return true;
        }

                
        // SHOW LIST OF CHARS METHODS
        public static void ShowList(this List<char> list, string listName)
        {
            Console.Write($"{listName} contains: ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");
        }

        public static void ShowList (this List<char> list)
        {
            Console.Write($"list contains: ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");
        }


        // SHOW LIST OF OBJECTS METHODS
        public static void ShowList( this List<object> list, string listName )
        {
            Console.Write ($"{listName} contains: ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");
        }

        public static void ShowList(this List<object> list)
        {
            Console.Write($"list contains: ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.Write($" {list[i]},");
            }
            Console.Write($" {list[list.Count-1]}\n");
        }


        // SHOW LIST OF STRINGS METHODS
        public static void ShowList(this List<string> list, string listName)
        {
            Console.Write($"{listName} contains:\n ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.WriteLine($"\"{list[i]}\",");
            }
            Console.Write($"\"{list[list.Count-1]}\"\n");           
        }

        public static void ShowList(this List<string> list)
        {
            Console.Write($"list contains:\n ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.WriteLine($"\"{list[i]}\",");
            }
            Console.Write($"\"{list[list.Count-1]}\"\n");
        }


        // SHOW LIST OF DECIMALS METHODS
        public static void ShowList(this List<decimal> list, string listName)
        {
            Console.Write($"{listName} contains:\n ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.WriteLine($"{list[i]},");
            }
            Console.Write($"{list[list.Count-1]}\n");
        }

        public static void ShowList(this List<decimal> list)
        {
            Console.Write($"list contains:\n ");
            for (int i = 0; i < list.Count - 1; i++)
            {
                Console.WriteLine($"{list[i]},");
            }
            Console.Write($"{list[list.Count-1]}\n");
        }


        /// <summary>
        /// Compares two positive(!) numbers in their digit-list representation
        /// for their value
        /// </summary>
        /// <param name="listDigits"></param>
        /// <param name="comparedDigitsList"></param>
        /// <returns>true if number, represented in list is not smaller than
        /// number, represented in comparedDigitsList</returns>
        public static bool IsNotSmallerThan(this List<int> listDigits, List<int> comparedDigitsList)
        {
            if (listDigits.Count > comparedDigitsList.Count)
            {
                return true;
            }

            else if (comparedDigitsList.Count > listDigits.Count)
            {
                return false;
            }

            else
            {
                for (int i = 0; i < listDigits.Count; i++)
                {
                    if (comparedDigitsList[i] > listDigits[i])
                    {
                        return false;
                    }
                    if (listDigits[i] > comparedDigitsList[i])
                    {
                        return true;
                    }


                }

                return true;
            }

        }


        public static bool IsSmallerThan (this List<int> list, List<int> comparedDigitsList)
        {
            if (list.IsNotSmallerThan(comparedDigitsList))
            {
                return false;
            }

            else
            {
                return true;
            }
        }



    }
}
