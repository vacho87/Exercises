using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class HelpersTests
    {
        [TestCase("4", TestName = "4 is correct number of Exrcise", ExpectedResult = true)]
        [TestCase("1", TestName = "1 is incorrect number of Exrcise", ExpectedResult = false)]
        [TestCase("p", TestName = "p is correct number of Exrcise", ExpectedResult = false)]
        public bool InputIsCorrectExerciseNumberTest(string input)
        {
          return ServiceClass.InputIsCorrectExerciseNumber(input); 
        }


        
    }
}
