using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class DigitList
    {
        private List<int> listOfDigits;
        private byte numberBase;


        public DigitList(int initialNumber)
        {
            listOfDigits = new List<int>(Decompose10BasedNumberToListWithAnyBase(initialNumber, 10));
            numberBase = 10;
        }

        public DigitList(int initialNumber, byte numberBase)
        {
            listOfDigits = new List<int>(Decompose10BasedNumberToListWithAnyBase(initialNumber, numberBase));
            this.numberBase = numberBase; 
                
        }

        public void ChangeBase (byte baseToSet)
        {
            if (baseToSet != numberBase)
            {
                int number = ComposeNumberListWithAnyBaseTo10BasedNumber(listOfDigits, numberBase);
                listOfDigits = Decompose10BasedNumberToListWithAnyBase(number, baseToSet);
                numberBase = baseToSet;
            }
            else
            {
                Console.WriteLine($"\nBase of the list-of-digit-represented number wasn't changed" +
                    $" because you have chose number base = {numberBase}, the same base as it had");
            }
             
        }

        public void ShowListOfDigits()
        {
            Console.WriteLine($"Object of type \"{this.GetType()}\" holds the number" +
                $" {ComposeNumberListWithAnyBaseTo10BasedNumber(listOfDigits, numberBase)}.");
            Console.Write($"And in list-of-digit representation in base = {numberBase} " );
            listOfDigits.ShowList();
        }


        public static List<int> Decompose10BasedNumberToListWithAnyBase(int number, byte baseToSet)
        {           
            List<int> resultList = new List<int>();
            while (number != 0)
            {
                resultList.Add(number % baseToSet);
                number /= baseToSet;
            }

            resultList.Reverse();
            return resultList;
        }

       
        public static int ComposeNumberListWithAnyBaseTo10BasedNumber(List<int> numberList, byte numberListBase)
        {
            numberList = new List<int>(numberList);
            numberList.Reverse();
            int resultNUmber = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                resultNUmber += numberList[i] * (int)Math.Pow(numberListBase, i);
            }

            return resultNUmber;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType() != this.GetType()) return false;
            DigitList digitList = (DigitList)obj; 
            return (this.listOfDigits.IsEqual(digitList.listOfDigits) && this.numberBase == digitList.numberBase);
        }
    }
}