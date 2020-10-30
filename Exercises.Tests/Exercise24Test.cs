using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise24Test
    {
        [Test]
        public void ReturnElementsOnOddPositionTest ()
        {
            List<int> sourceList = new List<int> { 1, 2, 3, 4, 5 };
            List<int> expectedList = new List<int> { 1, 3, 5 };

            List<int> resultList = Exercise24.ReturnElementsOnOddPosition(sourceList);

            Assert.AreEqual(expectedList, resultList);
        }
    }
}
