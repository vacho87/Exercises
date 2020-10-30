using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise23Test
    {
        [Test]
        public void ContainsElementTest ()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            Assert.IsTrue(Exercise23.ContainsElement(list, 3));
;        }

        [Test]
        public void NotContainsElement ()
        {
            List<int> list = new List<int> { 1, 2, 3, 4, 5 };
            Assert.IsFalse(Exercise23.ContainsElement(list, 6));
        }
    }
}
