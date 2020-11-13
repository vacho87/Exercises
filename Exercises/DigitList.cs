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
        readonly byte numberBase;

        public DigitList(int initialNumber)
        {
            listOfDigits = new List<int>(Exercise214.DecomposeNumber(initialNumber));
            numberBase = 10;
        }





    }
}
