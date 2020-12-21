using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise29Test
    {
        [Test]
        public void ConcatenateTwoListsTest ()
        {
            List<object> list1 = new List<object> { 1, 2, 3 };
            List<object> List2 = new List<object> { "a", "b", "c" };
            List<object> exeptedList = new List<object> { 1, 2, 3, "a", "b", "c" };

            List<object> concatenatedList = Exercise29.ConcatenateTwoLists(list1, List2);

            Assert.AreEqual(exeptedList, concatenatedList);
        }
    }
}
