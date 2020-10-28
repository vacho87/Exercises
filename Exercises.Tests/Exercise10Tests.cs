using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise10Tests
    {
        [TestCase("2020-9-15", TestName = "2020 is leap year", ExpectedResult = true)]
        [TestCase("2021-1-10", TestName = "2021 isn't leap year", ExpectedResult = false)]
        public bool CurrentYearIsLeapTest(DateTime year)
        {
           return Exercise10.CurrentYearIsLeap(year);
        }


       [Test]
        public void CurrentYearIsLeapAnotherTest()
        {
            // Arrange
            DateTime date = new DateTime(2020, 09, 15);

            // Act
            bool b = Exercise10.CurrentYearIsLeap(date);

            // Assert
            Assert.IsTrue(b);

        }
        [Test]
        public void ReturnNext20LeapYearsTest()
        {
            // Arrange
            int[] correctResult = new int[] { 2024, 2028, 2032, 2036, 2040, 2044, 2048, 2052, 2056, 2060, 2064, 2068, 2072, 2076, 2080, 2084, 2088, 2092, 2096, 2100 };
            DateTime year = new DateTime(2021, 01, 01);
            // Act
            int[] result = Exercise10.ReturnNext20LeapYears(year); 
            //Assert
            Assert.AreEqual(result, correctResult);
        }



    }

}
