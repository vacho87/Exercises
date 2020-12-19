using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise218Test
    {
        [Test]
        public void BinarySearchTest()
        {
            List<int> list1 = new List<int> { 0, 1, 2, 4, 7, 10, 14, 45, 101 };
            List<int> list2 = new List<int> { 1, 2, 2, 2, 3, 5, 7, 9 };
            List<int> list3 = new List<int> { 2, 2, 3, 3, 4, 5, 7, 13, 66, 77 };
            List<int> list4 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 14, 16, 19, 20, 22, 29, 30, 40, 51, 62, 73, 84, 95, 106 };
            List<int> list5 = new List<int> { 1, 2 };
            List<int> list6 = new List<int> { 100 };
            List<int> list7 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 14, 16, 19, 20, 22, 29, 30, 40, 51, 62, 73, 84, 95, 106 };
            List<int> list8 = new List<int> { 100 };
            int numberForSearch1 = 45;
            int numberForSearch2 = 2;
            int numberForSearch3 = 3;
            int numberForSearch4 = 13;
            int numberForSearch5 = 1;
            int numberForSearch6 = 1;
            int numberForSearch7 = 95;
            int numberForSearch8 = 100;
            int expectedIndex1 = 7;
            int expectedIndex2 = 1;
            int expectedIndex3 = 2;
            int expectedIndex4 = -1;
            int expectedIndex5 = 0;
            int expectedIndex6 = -1;
            int expectedIndex7 = 23;
            int expectedIndex8 = 0;



            int detectedIndex1 = Exercise218.BinarySearch(list1, numberForSearch1);
            int detectedIndex2 = Exercise218.BinarySearch(list2, numberForSearch2);
            int detectedIndex3 = Exercise218.BinarySearch(list3, numberForSearch3);
            int detectedIndex4 = Exercise218.BinarySearch(list4, numberForSearch4);
            int detectedIndex5 = Exercise218.BinarySearch(list5, numberForSearch5);
            int detectedIndex6 = Exercise218.BinarySearch(list6, numberForSearch6);
            int detectedIndex7 = Exercise218.BinarySearch(list7, numberForSearch7);
            int detectedIndex8 = Exercise218.BinarySearch(list8, numberForSearch8);



            Assert.AreEqual(expectedIndex1, detectedIndex1);
            Assert.AreEqual(expectedIndex2, detectedIndex2);
            Assert.AreEqual(expectedIndex3, detectedIndex3);
            Assert.AreEqual(expectedIndex4, detectedIndex4);
            Assert.AreEqual(expectedIndex5, detectedIndex5);
            Assert.AreEqual(expectedIndex6, detectedIndex6);
            Assert.AreEqual(expectedIndex7, detectedIndex7);
            Assert.AreEqual(expectedIndex8, detectedIndex8);

        }
    }
}
