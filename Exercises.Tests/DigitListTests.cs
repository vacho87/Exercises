using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture] 
    class DigitListTests
    {
        [Test]
        public void ComposeNumberListWithAnyBaseTo10BasedNumberTest()
        {
            List<int> list = new List<int> { 1, 2, 0, 8 };
            byte numberBase = 10;
            int expectedComposedNUmber = 1208;

            List<int> list1 = new List<int> { 1, 0, 1, 1, 1 };
            byte numberBase1 = 2;
            int expectedComposedNUmber1 = 23;

            List<int> list2 = new List<int> { 6, 5, 1};
            byte numberBase2 = 8;
            int expectedComposedNUmber2 = 425;


           int composedNumber =  DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list, numberBase);
           int composedNumber1 = DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list1, numberBase1);
           int composedNumber2 = DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list2, numberBase2);


            Assert.AreEqual(expectedComposedNUmber, composedNumber);
            Assert.AreEqual(expectedComposedNUmber1, composedNumber1);
            Assert.AreEqual(expectedComposedNUmber2, composedNumber2);
        }


        [Test]
        public void ChangeNumberListBaseFromAnyTo10Test()
        {
            byte numberBase = 10;
            List<int> list = new List<int> { 1, 2, 0, 8 };
            List<int> expectedList = new List<int> { 1, 2, 0, 8 };

            byte numberBase1 = 2;
            List<int> list1 = new List<int> { 1, 0, 1, 1, 1 };
            List<int> expectedList1 = new List<int> { 2, 3 };

            byte numberBase2 = 8;
            List<int> list2 = new List<int> { 6, 5, 1 };
            List<int> expectedList2 = new List<int> { 4, 2, 5 };


            List<int> resultList = DigitList.ChangeNumberListBaseFromAnyTo10(list, numberBase);
            List<int> resultList1 = DigitList.ChangeNumberListBaseFromAnyTo10(list1, numberBase1);
            List<int> resultList2 = DigitList.ChangeNumberListBaseFromAnyTo10(list2,  numberBase2);


            Assert.AreEqual(expectedList, resultList);
            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
        }

        public void ChangeNumberListBaseFrom10ToAnyOtherTest()
        {
            byte baseToSet = 10;
            List<int> list = new List<int> { 1, 2, 0, 8 };
            List<int> expectedList = new List<int> { 1, 2, 0, 8 };

            byte baseToSet1 = 2;
            List<int> list1 = new List<int> { 1, 7, 8 };
            List<int> expectedList1 = new List<int> { 1, 0, 1, 1, 0, 0, 1, 0 };

            byte baseToSet3 = 3;
            List<int> list3 = new List<int> { 2, 1 };
            List<int> expectedList3 = new List<int> { 2, 1, 0 };

            byte baseToSet4 = 8;
            List<int> list4 = new List<int> { 9, 9 };
            List<int> expectedList4 = new List<int> { 1, 4, 3 };


            List<int> resultList = ChangeNumberListBaseFrom10ToAnyOther(list, baseToSet);





        }



    }
}
