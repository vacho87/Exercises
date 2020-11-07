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

    }
}
