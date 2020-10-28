using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise21Test
    {
        [Test]
        public void ReturnTheLargestIntElementTest()
        {
            List<int> numberList = new List<int> { 2, 7, 1, 1 };
            int expectedResult = 7;
            int result = Exercise21.ReturnTheLargestIntElement(numberList);

            Assert.AreEqual(expectedResult, result);
        }


    }
}
