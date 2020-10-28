using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise22Test
    {
        [Test]
        public void ReversListWithOddNumberOfMembersTest()
        {
            List<int> testList = new List<int> { 1, 2, 3 };
            List<int> expectedList = new List<int> { 3, 2, 1 };

            Exercise22.ReverseList(testList);

            Assert.AreEqual(expectedList, testList);
        }

        [Test]
        public void ReversListWithEvenNumberOfMembersTest()
        {
            List<int> testList = new List<int> { 4, 5, 6, 7 };
            List<int> expectedList = new List<int> { 7, 6, 5, 4 };

            Exercise22.ReverseList(testList);

            Assert.AreEqual(expectedList, testList);
        }
    }
}
