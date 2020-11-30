using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise216Test
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

            List<int> list2 = new List<int> { 6, 5, 1 };
            byte numberBase2 = 8;
            int expectedComposedNUmber2 = 425;


            int composedNumber = DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list, numberBase);
            int composedNumber1 = DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list1, numberBase1);
            int composedNumber2 = DigitList.ComposeNumberListWithAnyBaseTo10BasedNumber(list2, numberBase2);


            Assert.AreEqual(expectedComposedNUmber, composedNumber);
            Assert.AreEqual(expectedComposedNUmber1, composedNumber1);
            Assert.AreEqual(expectedComposedNUmber2, composedNumber2);
        }


        [Test]
        public void Decompose10BasedNumberToAnyBasedListTest()
        {
            int numberIn10Base1 = 1208;
            byte baseToSet1 = 10;
            List<int> expectedList1 = new List<int> { 1, 2, 0, 8 };

            int numberIn10Base2 = 1208;
            byte baseToSet2 = 2;
            List<int> expectedList2 = new List<int> { 1, 0, 0, 1, 0, 1, 1, 1, 0, 0, 0 };

            int numberIn10Base3 = 1208;
            byte baseToSet3 = 8;
            List<int> expectedList3 = new List<int> { 2, 2, 7, 0 };

            int numberIn10Base4 = 21;
            byte baseToSet4 = 3;
            List<int> expectedList4 = new List<int> { 2, 1, 0 };


            List<int> resultList1 = DigitList.Decompose10BasedNumberToListWithAnyBase(numberIn10Base1, baseToSet1);
            List<int> resultList2 = DigitList.Decompose10BasedNumberToListWithAnyBase(numberIn10Base2, baseToSet2);
            List<int> resultList3 = DigitList.Decompose10BasedNumberToListWithAnyBase(numberIn10Base3, baseToSet3);
            List<int> resultList4 = DigitList.Decompose10BasedNumberToListWithAnyBase(numberIn10Base4, baseToSet4);


            Assert.AreEqual(expectedList1, resultList1);
            Assert.AreEqual(expectedList2, resultList2);
            Assert.AreEqual(expectedList3, resultList3);
            Assert.AreEqual(expectedList4, resultList4);
        }


        [Test]
        public void ChangeBaseTest()
        {
            byte baseToSet1 = 2;
            DigitList digitList1 = new DigitList(132, 10);
            DigitList expectedDigitList1 = new DigitList(132, 2);

            byte baseToSet2 = 8;
            DigitList digitList2 = new DigitList(57, 2);
            DigitList expectedDigitList2 = new DigitList(57, 8);

            byte baseToSet3 = 10;
            DigitList digitList3 = new DigitList(44, 8);
            DigitList expectedDigitList3= new DigitList(44, 10);

            byte baseToSet4 = 4;
            DigitList digitList4 = new DigitList(10, 4);
            DigitList expectedDigitList4 = new DigitList(10, 4);


            digitList1.ChangeBase(baseToSet1);
            digitList2.ChangeBase(baseToSet2);
            digitList3.ChangeBase(baseToSet3);
            digitList4.ChangeBase(baseToSet4);


            Assert.IsTrue(digitList1.Equals(expectedDigitList1));
            Assert.IsTrue(digitList2.Equals(expectedDigitList2));
            Assert.IsTrue(digitList3.Equals(expectedDigitList3));
            Assert.IsTrue(digitList4.Equals(expectedDigitList4));
        }
    }
}
