using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise210Test 
    {
        [Test]
        [Description ("Tests method Exercise210.MixTwoLists for lists with equal number of items")]
        public void MixTwoListsTest ()
        {
            List<object> list1 = new List<object> { 1, 2, 3 };
            List<object> list2 = new List<object> { "a", "b", "c" };
            List<object> expectedList = new List<object> { 1, "a", 2, "b", 3, "c" };

            var mixedList = Exercise210.MixTwoLists(list1, list2);

            Assert.AreEqual(expectedList, mixedList);
        }

        [Test]
        [Description("Tests method Exercise210.MixTwoLists for lists with diverse number of items")]
        public void MixTwoListsTest2 ()
        {
            List<object> list1 = new List<object> { 1, 2, 3, 4, 5, 6 };
            List<object> list2 = new List<object> { "a", "b", "c" };
            List<object> expectedList = new List<object> { 1, "a", 2, "b", 3, "c", 4, 5, 6 };

            var mixedList = Exercise210.MixTwoLists(list1, list2);

            Assert.AreEqual(expectedList, mixedList);
        }

    }
}
