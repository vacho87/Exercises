using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    public class DigitList
    {
        readonly List<int> listOfDigits;
        readonly int numberBase;


        public DigitList(int initialNumber)
        {
            listOfDigits = new List<int>(Exercise214.DecomposeNumber(initialNumber));
            numberBase = 10;
        }

        public DigitList(int initialNumber, int numberBase)
        {
            listOfDigits = new List<int>(Exercise214.DecomposeNumber(initialNumber));
            this.numberBase = numberBase; 
                
        }

        public void ChangeBase (int baseToSet)
        {

        }

        public List<int> ChangeNumberListBaseFrom10ToAnyOther(List<int> numberWith10BaseList, byte otherBase)
        {
            int composedNumberWith10Base = ComposeNumberListWithAnyBaseTo10BasedNumber(numberWith10BaseList, 10);

            List<int> resultList = new List<int>();
            int quotient = composedNumberWith10Base;
            while (quotient != 0)
            {
                resultList.Add(quotient % otherBase);
                quotient /= otherBase;
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
