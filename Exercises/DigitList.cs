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
            listOfDigits = new List<int>(Exercise214.DecomposeNumber(initialNumber));
            numberBase = 10;
        }

        public DigitList(int initialNumber, byte numberBase)
        {
            listOfDigits = new List<int>(Exercise214.DecomposeNumber(initialNumber));
            this.numberBase = numberBase; 
                
        }

        public void ChangeBase (byte baseToSet)
        {
            if (baseToSet != numberBase)
            {
                // здесь не применил тренарный оператор лишь потому, что выражение получалось слишком длинным в одну строку
                // да и читается, мне кажется, в данном случае лучше в таком виде
                if (baseToSet == 10)
                {
                    listOfDigits = ChangeNumberListBaseFromAnyTo10(listOfDigits, numberBase);
                }
                else
                {
                    ChangeNumberListBaseFrom10ToAnyOther(listOfDigits, baseToSet);
                }
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


        public List<int> ChangeNumberListBaseFrom10ToAnyOther(List<int> numberWith10BaseList, byte baseToSet)
        {
            int composedNumberWith10Base = ComposeNumberListWithAnyBaseTo10BasedNumber(numberWith10BaseList, 10);

            List<int> resultList = new List<int>();
            int quotient = composedNumberWith10Base;
            while (quotient != 0)
            {
                resultList.Add(quotient % baseToSet);
                quotient /= baseToSet;
            }

            resultList.Reverse();
            return resultList;
        }


        public List<int> ChangeNumberListBaseFromAnyTo10 (List<int> numberListWithAnyBase, byte numberListBase)
        {
            int composedNumberWith10Base = ComposeNumberListWithAnyBaseTo10BasedNumber(numberListWithAnyBase, numberListBase);
            return Exercise214.DecomposeNumber(composedNumberWith10Base);
        }


        public int ComposeNumberListWithAnyBaseTo10BasedNumber(List<int> numberList, byte numberListBase)
        {
            int resultNUmber = 0;
            for (int i = numberList.Count - 1; i >= 0; i--)
            {
                resultNUmber += numberList[i] * (int)Math.Pow(numberListBase, i);
            }
            return resultNUmber;
        }

    }
}
