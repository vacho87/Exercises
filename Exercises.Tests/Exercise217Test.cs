using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise217Test
    {
        [Test]
        public void SortBySelectionTest()
        {
            List<int> list1 = new List<int> { 2, 3, 0, 1, 1, 0, 9, 5, 8, 2 };
            List<int> expectedList1 = new List<int> { 0, 0, 1, 1, 2, 2, 3, 5, 8, 9 };

            List<int> list2 = new List<int> { 0, 0, 3, 2, 1, 0, 9, 9, 8 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, 1, 2, 3, 8, 9, 9 };

            List<int> list3 = new List<int> { 1, 2, 3, 4, 0, 5 };
            List<int> expectedList3 = new List<int> { 0, 1, 2, 3, 4, 5 };

            List<int> list4 = new List<int> { 2, 0, 1 };
            List<int> expectedList4 = new List<int> { 0, 1, 2 };

            List<int> list5 = new List<int> { 2, 1, 0 };
            List<int> expectedList5 = new List<int> { 0, 1, 2 };

            List<int> list6 = new List<int> { 7, 6 };
            List<int> expectedList6 = new List<int> { 6, 7 };

            List<int> list7 = new List<int> { 4, 7, 4, 6, 2, 5, 2 };
            List<int> expectedList7 = new List<int> { 2, 2, 4, 4, 5, 6, 7 };

            List<int> list8 = new List<int> { 4, 7, 4, 9, 2, 5, 2 };
            List<int> expectedList8 = new List<int> { 2, 2, 4, 4, 5, 7, 9 };

            List<int> list9 = new List<int> { 2, 0, 0, 2, 9, 3, 1, 1, 0, 1, 0, 0, 5 };
            List<int> expectedList9 = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 5, 9 };

            List<int> list10 = new List<int> { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            List<int> expectedList10 = new List<int> { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

            List<int> list11 = new List<int> { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 1, 1, 2, 2, 5, 5, 3, 4, 3, 4 };
            List<int> expectedList11 = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };

            List<int> list12 = new List<int> { 9, 0, 9, 0, 3, 2, 5, 1, 4, 2, 3, 2 };
            List<int> expectedList12 = new List<int> { 0, 0, 1, 2, 2, 2, 3, 3, 4, 5, 9, 9 };

            List<int> list13 = new List<int> { 1, 2, 3, 5, 4, 7, 6, 8, 9 };
            List<int> expectedList13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list14 = new List<int> { 5, 4, 3, 2, 1, 1, 1, 2, 3, 4, 5, 9 };
            List<int> expectedList14 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 9 };


            List<int> resultList1 = Exercise217.SortBySelection(list1);
            List<int> resultList2 = Exercise217.SortBySelection(list2);
            List<int> resultList3 = Exercise217.SortBySelection(list3);
            List<int> resultList4 = Exercise217.SortBySelection(list4);
            List<int> resultList5 = Exercise217.SortBySelection(list5);
            List<int> resultList6 = Exercise217.SortBySelection(list6);
            List<int> resultList7 = Exercise217.SortBySelection(list7);
            List<int> resultList8 = Exercise217.SortBySelection(list8);
            List<int> resultList9 = Exercise217.SortBySelection(list9);
            List<int> resultList10 = Exercise217.SortBySelection(list10);
            List<int> resultList11 = Exercise217.SortBySelection(list11);
            List<int> resultList12 = Exercise217.SortBySelection(list12);
            List<int> resultList13 = Exercise217.SortBySelection(list13);
            List<int> resultList14 = Exercise217.SortBySelection(list14);



            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
            Assert.AreEqual(expectedList5, resultList5);
            Assert.AreEqual(expectedList6, resultList6);
            Assert.AreEqual(expectedList7, resultList7);
            Assert.AreEqual(expectedList8, resultList8);
            Assert.AreEqual(expectedList9, resultList9);
            Assert.AreEqual(expectedList10, resultList10);
            Assert.AreEqual(expectedList11, resultList11);
            Assert.AreEqual(expectedList12, resultList12);
            Assert.AreEqual(expectedList13, resultList13);
            Assert.AreEqual(expectedList14, resultList14);
        }


        [Test]
        public void SortByInsertionTest()
        {
            List<int> list1 = new List<int> { 2, 3, 0, 1, 1, 0, 9, 5, 8, 2 };
            List<int> expectedList1 = new List<int> { 0, 0, 1, 1, 2, 2, 3, 5, 8, 9 };

            List<int> list2 = new List<int> { 0, 0, 3, 2, 1, 0, 9, 9, 8 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, 1, 2, 3, 8, 9, 9 };

            List<int> list3 = new List<int> { 1, 2, 3, 4, 0, 5 };
            List<int> expectedList3 = new List<int> { 0, 1, 2, 3, 4, 5 };

            List<int> list4 = new List<int> { 2, 0, 1 };
            List<int> expectedList4 = new List<int> { 0, 1, 2 };

            List<int> list5 = new List<int> { 2, 1, 0 };
            List<int> expectedList5 = new List<int> { 0, 1, 2 };

            List<int> list6 = new List<int> { 7, 6 };
            List<int> expectedList6 = new List<int> { 6, 7 };

            List<int> list7 = new List<int> { 4, 7, 4, 6, 2, 5, 2 };
            List<int> expectedList7 = new List<int> { 2, 2, 4, 4, 5, 6, 7 };

            List<int> list8 = new List<int> { 4, 7, 4, 9, 2, 5, 2 };
            List<int> expectedList8 = new List<int> { 2, 2, 4, 4, 5, 7, 9 };

            List<int> list9 = new List<int> { 2, 0, 0, 2, 9, 3, 1, 1, 0, 1, 0, 0, 5 };
            List<int> expectedList9 = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 5, 9 };

            List<int> list10 = new List<int> { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            List<int> expectedList10 = new List<int> { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

            List<int> list11 = new List<int> { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 1, 1, 2, 2, 5, 5, 3, 4, 3, 4 };
            List<int> expectedList11 = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };

            List<int> list12 = new List<int> { 9, 0, 9, 0, 3, 2, 5, 1, 4, 2, 3, 2 };
            List<int> expectedList12 = new List<int> { 0, 0, 1, 2, 2, 2, 3, 3, 4, 5, 9, 9 };

            List<int> list13 = new List<int> { 1, 2, 3, 5, 4, 7, 6, 8, 9 };
            List<int> expectedList13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list14 = new List<int> { 5, 4, 3, 2, 1, 1, 1, 2, 3, 4, 5, 9 };
            List<int> expectedList14 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 9 };


            List<int> resultList1 = Exercise217.SortByInsertion(list1);
            List<int> resultList2 = Exercise217.SortByInsertion(list2);
            List<int> resultList3 = Exercise217.SortByInsertion(list3);
            List<int> resultList4 = Exercise217.SortByInsertion(list4);
            List<int> resultList5 = Exercise217.SortByInsertion(list5);
            List<int> resultList6 = Exercise217.SortByInsertion(list6);
            List<int> resultList7 = Exercise217.SortByInsertion(list7);
            List<int> resultList8 = Exercise217.SortByInsertion(list8);
            List<int> resultList9 = Exercise217.SortByInsertion(list9);
            List<int> resultList10 = Exercise217.SortByInsertion(list10);
            List<int> resultList11 = Exercise217.SortByInsertion(list11);
            List<int> resultList12 = Exercise217.SortByInsertion(list12);
            List<int> resultList13 = Exercise217.SortByInsertion(list13);
            List<int> resultList14 = Exercise217.SortByInsertion(list14);



            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
            Assert.AreEqual(expectedList5, resultList5);
            Assert.AreEqual(expectedList6, resultList6);
            Assert.AreEqual(expectedList7, resultList7);
            Assert.AreEqual(expectedList8, resultList8);
            Assert.AreEqual(expectedList9, resultList9);
            Assert.AreEqual(expectedList10, resultList10);
            Assert.AreEqual(expectedList11, resultList11);
            Assert.AreEqual(expectedList12, resultList12);
            Assert.AreEqual(expectedList13, resultList13);
            Assert.AreEqual(expectedList14, resultList14);
        }

        [Test]
        public void SortByMergeTest()
        {
            List<int> list1 = new List<int> { 2, 3, 0, 1, 1, 0, 9, 5, 8, 2 };
            List<int> expectedList1 = new List<int> { 0, 0, 1, 1, 2, 2, 3, 5, 8, 9 };

            List<int> list2 = new List<int> { 0, 0, 3, 2, 1, 0, 9, 9, 8 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, 1, 2, 3, 8, 9, 9 };

            List<int> list3 = new List<int> { 1, 2, 3, 4, 0, 5 };
            List<int> expectedList3 = new List<int> { 0, 1, 2, 3, 4, 5 };

            List<int> list4 = new List<int> { 2, 0, 1 };
            List<int> expectedList4 = new List<int> { 0, 1, 2 };

            List<int> list5 = new List<int> { 2, 1, 0 };
            List<int> expectedList5 = new List<int> { 0, 1, 2 };

            List<int> list6 = new List<int> { 7, 6 };
            List<int> expectedList6 = new List<int> { 6, 7 };

            List<int> list7 = new List<int> { 4, 7, 4, 6, 2, 5, 2 };
            List<int> expectedList7 = new List<int> { 2, 2, 4, 4, 5, 6, 7 };

            List<int> list8 = new List<int> { 4, 7, 4, 9, 2, 5, 2 };
            List<int> expectedList8 = new List<int> { 2, 2, 4, 4, 5, 7, 9 };

            List<int> list9 = new List<int> { 2, 0, 0, 2, 9, 3, 1, 1, 0, 1, 0, 0, 5 };
            List<int> expectedList9 = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 5, 9 };

            List<int> list10 = new List<int> { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            List<int> expectedList10 = new List<int> { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

            List<int> list11 = new List<int> { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 1, 1, 2, 2, 5, 5, 3, 4, 3, 4 };
            List<int> expectedList11 = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };

            List<int> list12 = new List<int> { 9, 0, 9, 0, 3, 2, 5, 1, 4, 2, 3, 2 };
            List<int> expectedList12 = new List<int> { 0, 0, 1, 2, 2, 2, 3, 3, 4, 5, 9, 9 };

            List<int> list13 = new List<int> { 1, 2, 3, 5, 4, 7, 6, 8, 9 };
            List<int> expectedList13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list14 = new List<int> { 5, 4, 3, 2, 1, 1, 1, 2, 3, 4, 5, 9 };
            List<int> expectedList14 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 9 };



            List<int> resultList1 = Exercise217.SortByMerge(list1);
            List<int> resultList2 = Exercise217.SortByMerge(list2);
            List<int> resultList3 = Exercise217.SortByMerge(list3);
            List<int> resultList4 = Exercise217.SortByMerge(list4);
            List<int> resultList5 = Exercise217.SortByMerge(list5);
            List<int> resultList6 = Exercise217.SortByMerge(list6);
            List<int> resultList7 = Exercise217.SortByMerge(list7);
            List<int> resultList8 = Exercise217.SortByMerge(list8);
            List<int> resultList9 = Exercise217.SortByMerge(list9);
            List<int> resultList10 = Exercise217.SortByMerge(list10);
            List<int> resultList11 = Exercise217.SortByMerge(list11);
            List<int> resultList12 = Exercise217.SortByMerge(list12);
            List<int> resultList13 = Exercise217.SortByMerge(list13);
            List<int> resultList14 = Exercise217.SortByMerge(list14);



            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
            Assert.AreEqual(expectedList5, resultList5);
            Assert.AreEqual(expectedList6, resultList6);
            Assert.AreEqual(expectedList7, resultList7);
            Assert.AreEqual(expectedList8, resultList8);
            Assert.AreEqual(expectedList9, resultList9);
            Assert.AreEqual(expectedList10, resultList10);
            Assert.AreEqual(expectedList11, resultList11);
            Assert.AreEqual(expectedList12, resultList12);
            Assert.AreEqual(expectedList13, resultList13);
            Assert.AreEqual(expectedList14, resultList14);
        }


        [Test]
        public void StoogeSortTest()
        {
            List<int> list1 = new List<int> { 2, 3, 0, 1, 1, 0, 9, 5, 8, 2 };
            List<int> expectedList1 = new List<int> { 0, 0, 1, 1, 2, 2, 3, 5, 8, 9 };

            List<int> list2 = new List<int> { 0, 0, 3, 2, 1, 0, 9, 9, 8 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, 1, 2, 3, 8, 9, 9 };

            List<int> list3 = new List<int> { 1, 2, 3, 4, 0, 5 };
            List<int> expectedList3 = new List<int> { 0, 1, 2, 3, 4, 5 };

            List<int> list4 = new List<int> { 2, 0, 1 };
            List<int> expectedList4 = new List<int> { 0, 1, 2 };

            List<int> list5 = new List<int> { 2, 1, 0 };
            List<int> expectedList5 = new List<int> { 0, 1, 2 };

            List<int> list6 = new List<int> { 7, 6 };
            List<int> expectedList6 = new List<int> { 6, 7 };

            List<int> list7 = new List<int> { 4, 7, 4, 6, 2, 5, 2 };
            List<int> expectedList7 = new List<int> { 2, 2, 4, 4, 5, 6, 7 };

            List<int> list8 = new List<int> { 4, 7, 4, 9, 2, 5, 2 };
            List<int> expectedList8 = new List<int> { 2, 2, 4, 4, 5, 7, 9 };

            List<int> list9 = new List<int> { 2, 0, 0, 2, 9, 3, 1, 1, 0, 1, 0, 0, 5 };
            List<int> expectedList9 = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 5, 9 };

            List<int> list10 = new List<int> { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            List<int> expectedList10 = new List<int> { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

            List<int> list11 = new List<int> { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 1, 1, 2, 2, 5, 5, 3, 4, 3, 4 };
            List<int> expectedList11 = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };

            List<int> list12 = new List<int> { 9, 0, 9, 0, 3, 2, 5, 1, 4, 2, 3, 2 };
            List<int> expectedList12 = new List<int> { 0, 0, 1, 2, 2, 2, 3, 3, 4, 5, 9, 9 };

            List<int> list13 = new List<int> { 1, 2, 3, 5, 4, 7, 6, 8, 9 };
            List<int> expectedList13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list14 = new List<int> { 5, 4, 3, 2, 1, 1, 1, 2, 3, 4, 5, 9 };
            List<int> expectedList14 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 9 };



            List<int> resultList1 = list1;
            List<int> resultList2 = list2;
            List<int> resultList3 = list3;
            List<int> resultList4 = list4;
            List<int> resultList5 = list5;
            List<int> resultList6 = list6;
            List<int> resultList7 = list7;
            List<int> resultList8 = list8;
            List<int> resultList9 = list9;
            List<int> resultList10 = list10;
            List<int> resultList11 = list11;
            List<int> resultList12 = list12;
            List<int> resultList13 = list13;
            List<int> resultList14 = list14;
            Exercise217.StoogeSort(list1);
            Exercise217.StoogeSort(list2);
            Exercise217.StoogeSort(list3);
            Exercise217.StoogeSort(list4);
            Exercise217.StoogeSort(list5);
            Exercise217.StoogeSort(list6);
            Exercise217.StoogeSort(list7);
            Exercise217.StoogeSort(list8);
            Exercise217.StoogeSort(list9);
            Exercise217.StoogeSort(list10);
            Exercise217.StoogeSort(list11);
            Exercise217.StoogeSort(list12);
            Exercise217.StoogeSort(list13);
            Exercise217.StoogeSort(list14);



            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
            Assert.AreEqual(expectedList5, resultList5);
            Assert.AreEqual(expectedList6, resultList6);
            Assert.AreEqual(expectedList7, resultList7);
            Assert.AreEqual(expectedList8, resultList8);
            Assert.AreEqual(expectedList9, resultList9);
            Assert.AreEqual(expectedList10, resultList10);
            Assert.AreEqual(expectedList11, resultList11);
            Assert.AreEqual(expectedList12, resultList12);
            Assert.AreEqual(expectedList13, resultList13);
            Assert.AreEqual(expectedList14, resultList14);
        }

        [Test]
        public void SortByQSortTest()
        {
            List<int> list1 = new List<int> { 2, 3, 0, 1, 1, 0, 9, 5, 8, 2 };
            List<int> expectedList1 = new List<int> { 0, 0, 1, 1, 2, 2, 3, 5, 8, 9 };

            List<int> list2 = new List<int> { 0, 0, 3, 2, 1, 0, 9, 9, 8 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, 1, 2, 3, 8, 9, 9 };

            List<int> list3 = new List<int> { 1, 2, 3, 4, 0, 5 };
            List<int> expectedList3 = new List<int> { 0, 1, 2, 3, 4, 5 };

            List<int> list4 = new List<int> { 2, 0, 1 };
            List<int> expectedList4 = new List<int> { 0, 1, 2 };

            List<int> list5 = new List<int> { 2, 1, 0 };
            List<int> expectedList5 = new List<int> { 0, 1, 2 };

            List<int> list6 = new List<int> { 7, 6 };
            List<int> expectedList6 = new List<int> { 6, 7 };

            List<int> list7 = new List<int> { 4, 7, 4, 6, 2, 5, 2 };
            List<int> expectedList7 = new List<int> { 2, 2, 4, 4, 5, 6, 7 };

            List<int> list8 = new List<int> { 4, 7, 4, 9, 2, 5, 2 };
            List<int> expectedList8 = new List<int> { 2, 2, 4, 4, 5, 7, 9 };

            List<int> list9 = new List<int> { 2, 0, 0, 2, 9, 3, 1, 1, 0, 1, 0, 0, 5 };
            List<int> expectedList9 = new List<int> { 0, 0, 0, 0, 0, 1, 1, 1, 2, 2, 3, 5, 9 };

            List<int> list10 = new List<int> { 2, 2, 2, 1, 1, 1, 0, 0, 0 };
            List<int> expectedList10 = new List<int> { 0, 0, 0, 1, 1, 1, 2, 2, 2 };

            List<int> list11 = new List<int> { 5, 4, 3, 2, 1, 1, 2, 3, 4, 5, 1, 1, 2, 2, 5, 5, 3, 4, 3, 4 };
            List<int> expectedList11 = new List<int> { 1, 1, 1, 1, 2, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5, 5, 5 };

            List<int> list12 = new List<int> { 9, 0, 9, 0, 3, 2, 5, 1, 4, 2, 3, 2 };
            List<int> expectedList12 = new List<int> { 0, 0, 1, 2, 2, 2, 3, 3, 4, 5, 9, 9 };

            List<int> list13 = new List<int> { 1, 2, 3, 5, 4, 7, 6, 8, 9 };
            List<int> expectedList13 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            List<int> list14 = new List<int> { 5, 4, 3, 2, 1, 1, 1, 2, 3, 4, 5, 9 };
            List<int> expectedList14 = new List<int> { 1, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5, 9 };


            List<int> resultList1 = list1;
            List<int> resultList2 = list2;
            List<int> resultList3 = list3;
            List<int> resultList4 = list4;
            List<int> resultList5 = list5;
            List<int> resultList6 = list6;
            List<int> resultList7 = list7;
            List<int> resultList8 = list8;
            List<int> resultList9 = list9;
            List<int> resultList10 = list10;
            List<int> resultList11 = list11;
            List<int> resultList12 = list12;
            List<int> resultList13 = list13;
            List<int> resultList14 = list14;



            Exercise217.SortByQSort(list1);
            Exercise217.SortByQSort(list2);
            Exercise217.SortByQSort(list3);
            Exercise217.SortByQSort(list4);
            Exercise217.SortByQSort(list5);
            Exercise217.SortByQSort(list6);
            Exercise217.SortByQSort(list7);
            Exercise217.SortByQSort(list8);
            Exercise217.SortByQSort(list9);
            Exercise217.SortByQSort(list10);
            Exercise217.SortByQSort(list11);
            Exercise217.SortByQSort(list12);
            Exercise217.SortByQSort(list13);
            Exercise217.SortByQSort(list14);



            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
            Assert.AreEqual(expectedList5, resultList5);
            Assert.AreEqual(expectedList6, resultList6);
            Assert.AreEqual(expectedList7, resultList7);
            Assert.AreEqual(expectedList8, resultList8);
            Assert.AreEqual(expectedList9, resultList9);
            Assert.AreEqual(expectedList10, resultList10);
            Assert.AreEqual(expectedList11, resultList11);
            Assert.AreEqual(expectedList12, resultList12);
            Assert.AreEqual(expectedList13, resultList13);
            Assert.AreEqual(expectedList14, resultList14);

        }






    }
}
