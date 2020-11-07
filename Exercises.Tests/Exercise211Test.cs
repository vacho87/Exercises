using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise211Test
    {        
        [Test]
        public void MergeListsWithEqualCountOfItems ()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 5, 6, 10, 22 };
            List<int> list2 = new List<int> { 2, 2, 2, 7, 9, 11, 19 };
            List<int> expectedList = new List<int> { 1, 2, 2, 2, 2, 3, 5, 6, 7, 9, 10, 11, 19, 22 };

            List<int> resultList = Exercise211.MergeTwoSortedLists(list1, list2);

            Assert.AreEqual(expectedList, resultList);
        }

        [Test]
        public void MergeListsWithDifferentCountOfItems()
        {
            List<int> list1 = new List<int> { 1, 2, 3, 5, 6, 10, 22 };
            List<int> list2 = new List<int> { 2, 2, 2, 7, 9, 11, 19, 19, 100, 102 };
            List<int> expectedList = new List<int> { 1, 2, 2, 2, 2, 3, 5, 6, 7, 9, 10, 11, 19, 19, 22, 100, 102 };

            List<int> resultList = Exercise211.MergeTwoSortedLists(list1, list2);

            Assert.AreEqual(expectedList, resultList);
        }

        [Test]
        public void MergeListsWhenOneIsASubsetOfTheOther ()
        {
            List<int> list1 = new List<int> { 2, 2, 2, 7, 9, 11, 19 };
            List<int> list2 = new List<int> { 2, 2, 2, 7, 9, 11, 19, 19, 100, 102 };
            List<int> expectedList = new List<int> { 2, 2, 2, 2, 2, 2, 7, 7, 9, 9, 11, 11, 19, 19, 19, 100, 102 };

            List<int> resultList = Exercise211.MergeTwoSortedLists(list1, list2);

            Assert.AreEqual(expectedList, resultList);
        }

        [Test]
        public void MergeListsWhichHaveNoCommonItems()
        {
            List<int> list1 = new List<int> { 2, 2, 2, 7, 9, 11, 19 };
            List<int> list2 = new List<int> { 57, 105, 105, 106 };
            List<int> expectedList = new List<int> { 2, 2, 2, 7, 9, 11, 19, 57, 105, 105, 106 };

            List<int> resultList = Exercise211.MergeTwoSortedLists(list1, list2);

            Assert.AreEqual(expectedList, resultList);
        }

        [Test]
        public void MergeTwoEqualLists ()
        {
            List<int> list1 = new List<int> { 57, 105, 105, 106 };
            List<int> list2 = new List<int> { 57, 105, 105, 106 };
            List<int> expectedList = new List<int> { 57, 57, 105, 105, 105, 105, 106, 106 };

            List<int> resultList = Exercise211.MergeTwoSortedLists(list1, list2);

            Assert.AreEqual(expectedList, resultList);
        }     

    }
}
