using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise27Test
    {
        List<int> list = new List<int> { 1, 2, 3, 4, 5, 6 };
        
        [Test]
        public void CountSumWithWhileCycleTest ()
        {
            Assert.AreEqual(21, Exercise27.CountSumWithWhileCycle(list));
        }

        [Test]
        public void CountSumWithForCycleTest()
        {
            Assert.AreEqual(21, Exercise27.CountSumWithForCycle(list));
        }

        [Test]
        public void CountSumWithRecursionTest()
        {
            Assert.AreEqual(21, Exercise27.CountSumWithRecursion(list));
        }

    }
}
