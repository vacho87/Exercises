using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise25Test
    {
        [Test]
        public void ComputeRunningTotalOfListTest ()
        {
            List<int> list = new List<int> { 1, 3, 1 };
            int expectedRunningTotal = 3;
            int actualRunningTotal;

            actualRunningTotal = Exercise25.ComputeRunningTotalOfList(list);

            Assert.AreEqual(expectedRunningTotal, actualRunningTotal);
        }
    }
}
