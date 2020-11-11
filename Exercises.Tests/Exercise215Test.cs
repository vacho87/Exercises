using NUnit.Framework;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise215Test
    {
        [Test]
        public void GetListWithChangedSignTest()
        {
            List<int> list = new List<int> { -1, -2, 0 };
            List<int> expected = new List<int> { 1, 2, 0 };

            List<int> list1 = new List<int> { 2, 3, 5 };
            List<int> expected1 = new List<int> { -2, -3, -5 };

            List<int> list2 = new List<int> { 0 };
            List<int> expected2 = new List<int> { 0 };


            List<int> result = Exercise215.GetListWithChangedSign(list);
            List<int> result1 = Exercise215.GetListWithChangedSign(list1);
            List<int> result2 = Exercise215.GetListWithChangedSign(list2);


            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }


        [Test]
        public void IsNumberInListPositiveTest()
        {
            List<int> list = new List<int> { -1, -2, 0 };
            bool expected = false;

            List<int> list1 = new List<int> { 2, 3, 5 };
            bool expected1 = true;

            List<int> list2 = new List<int> { 0 };
            bool expected2 = false;


            bool result = Exercise215.IsNumberInListPositive(list);
            bool result1 = Exercise215.IsNumberInListPositive(list1);
            bool result2 = Exercise215.IsNumberInListPositive(list2);


            Assert.AreEqual(expected, result);
            Assert.AreEqual(expected1, result1);
            Assert.AreEqual(expected2, result2);
        }


        [Test]
        public void OnlyOneListContainsPositiveNUmberTest()
        {
            List<int> negative = new List<int> { -1, 0 };
            List<int> positive = new List<int> { 2, 3 };
            List<int> @null = new List<int> { 0 };

            bool result = Exercise215.OnlyOneListContainsPositiveNUmber(negative, positive);
            Assert.IsTrue(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(positive, negative);
            Assert.IsTrue(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(positive, @null);
            Assert.IsTrue(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(negative, negative);
            Assert.IsFalse(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(positive, positive);
            Assert.IsFalse(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(negative, @null);
            Assert.IsFalse(result);

            result = Exercise215.OnlyOneListContainsPositiveNUmber(@null, @null);
            Assert.IsFalse(result);
        }


        [Test]
        public void EqualizeNUmberOfDigitsInTwoDigitsListsTest()
        {
            List<int> list1 = new List<int> { -1, -2, 0, -7 };
            List<int> list2 = new List<int> { -3 };
            List<int> list3 = new List<int> { 3, 0 };
            List<int> list4 = new List<int> { 4, 0, 5 };

            List<int> expectedList1 = new List<int> { -1, -2, 0, -7 };
            List<int> expectedList2 = new List<int> { 0, 0, 0, -3 };
            List<int> expectedList3 = new List<int> { 0, 3, 0 };
            List<int> expectedList4 = new List<int> { 4, 0, 5 };

            Exercise215.EqualizeNUmberOfDigitsInTwoDigitsLists(list1, list2);
            Exercise215.EqualizeNUmberOfDigitsInTwoDigitsLists(list3, list4);

            Assert.AreEqual(expectedList1, list1);
            Assert.AreEqual(expectedList2, list2);
            Assert.AreEqual(expectedList3, list3);
            Assert.AreEqual(expectedList4, list4);
        }


        [Test]
        public void PrepareResultListOfDigitsToReturnTest()
        {
            List<int> rawResultList = new List<int> { 1, 3, 0, 0, 0 };
            List<int> expectedResultList = new List<int> { 3, 1 };

            List<int> rawResultList1 = new List<int> { 0, 0, 0 };
            List<int> expectedResultList1 = new List<int> { 0 };

            List<int> rawResultList2 = new List<int> { -5, -1 };
            List<int> expectedResultList2 = new List<int> { -1, -5 };

            List<int> rawResultList3 = new List<int> { 0, 0, 0, 2, 2 };
            List<int> expectedResultList3 = new List<int> { 2, 2, 0, 0, 0 };


            Exercise215.PrepareResultListOfDigitsToReturn(rawResultList);
            Exercise215.PrepareResultListOfDigitsToReturn(rawResultList1);
            Exercise215.PrepareResultListOfDigitsToReturn(rawResultList2);
            Exercise215.PrepareResultListOfDigitsToReturn(rawResultList3);


            Assert.AreEqual(expectedResultList, rawResultList);
            Assert.AreEqual(expectedResultList1, rawResultList1);
            Assert.AreEqual(expectedResultList2, rawResultList2);
            Assert.AreEqual(expectedResultList3, rawResultList3);
        }


        [Test]
        public void UseSimpleSubtractionTest()
        {
            List<int> minuend = new List<int> { 5 };
            List<int> subtrahend = new List<int> { 5 };
            List<int> expectedRemainder = new List<int> { 0 };

            List<int> minuend1 = new List<int> { 1, 5, 3 };
            List<int> subtrahend1 = new List<int> { 6, 2 };
            List<int> expectedRemainder1 = new List<int> { 9, 1 };

            List<int> minuend2 = new List<int> { 1, 0, 0, 1 };
            List<int> subtrahend2 = new List<int> { 9, 9, 9 };
            List<int> expectedRemainder2 = new List<int> { 2 };

            List<int> minuend3 = new List<int> { 6, 2 };
            List<int> subtrahend3 = new List<int> { 1, 5, 3 };
            List<int> expectedRemainder3 = new List<int> { -9, -1 };

            List<int> minuend4 = new List<int> { 0 };
            List<int> subtrahend4 = new List<int> { 6, 2 };
            List<int> expectedRemainder4 = new List<int> { -6, -2 };

            List<int> minuend5 = new List<int> { 3, 5 };
            List<int> subtrahend5 = new List<int> { 2, 7 };
            List<int> expectedRemainder5 = new List<int> { 8 };


            List<int> remainder = Exercise215.UseSimpleSubtraction(minuend, subtrahend);
            List<int> remainder1 = Exercise215.UseSimpleSubtraction(minuend1, subtrahend1);
            List<int> remainder2 = Exercise215.UseSimpleSubtraction(minuend2, subtrahend2);
            List<int> remainder3 = Exercise215.UseSimpleSubtraction(minuend3, subtrahend3);
            List<int> remainder4 = Exercise215.UseSimpleSubtraction(minuend4, subtrahend4);
            List<int> remainder5 = Exercise215.UseSimpleSubtraction(minuend5, subtrahend5);


            Assert.AreEqual(expectedRemainder, remainder);
            Assert.AreEqual(expectedRemainder1, remainder1);
            Assert.AreEqual(expectedRemainder2, remainder2);
            Assert.AreEqual(expectedRemainder3, remainder3);
            Assert.AreEqual(expectedRemainder4, remainder4);
            Assert.AreEqual(expectedRemainder5, remainder5);
        }


        [Test]
        public void UseSimpleAdditionTest()
        {
            List<int> firstAddend = new List<int> { 3, 5 };
            List<int> secondAddend = new List<int> { 8, 3 };
            List<int> expectedSumm = new List<int> { 1, 1, 8 };

            List<int> firstAddend1 = new List<int> { 0 };
            List<int> secondAddend1 = new List<int> { 1, 9 };
            List<int> expectedSumm1 = new List<int> { 1, 9 };

            List<int> firstAddend2 = new List<int> { 2, 3 };
            List<int> secondAddend2 = new List<int> { 0 };
            List<int> expectedSumm2 = new List<int> { 2, 3 };

            List<int> firstAddend3 = new List<int> { 2 };
            List<int> secondAddend3 = new List<int> { 9, 9, 9 };
            List<int> expectedSumm3 = new List<int> { 1, 0, 0, 1 };


            List<int> sum = Exercise215.UseSimpleAddition(firstAddend, secondAddend);
            List<int> sum1 = Exercise215.UseSimpleAddition(firstAddend1, secondAddend1);
            List<int> sum2 = Exercise215.UseSimpleAddition(firstAddend2, secondAddend2);
            List<int> sum3 = Exercise215.UseSimpleAddition(firstAddend3, secondAddend3);


            Assert.AreEqual(expectedSumm, sum);
            Assert.AreEqual(expectedSumm1, sum1);
            Assert.AreEqual(expectedSumm2, sum2);
            Assert.AreEqual(expectedSumm3, sum3);
        }


        [Test]
        public void MultiplyTwoNumbersDigitsTest()
        {
            List<int> firstFactor1 = new List<int> { 0 };
            List<int> secondFactor1 = new List<int> { 8, 3 };
            List<int> expectedProduct1 = new List<int> { 0 };

            List<int> firstFactor2 = new List<int> { 1, 5, 5 };
            List<int> secondFactor2 = new List<int> { 2 };
            List<int> expectedProduct2 = new List<int> { 3, 1, 0 };

            List<int> firstFactor3 = new List<int> { -2, 0 };
            List<int> secondFactor3 = new List<int> { 2, 5 };
            List<int> expectedProduct3 = new List<int> { -5, 0, 0 };

            List<int> firstFactor4 = new List<int> { -3, -4 };
            List<int> secondFactor4 = new List<int> { -2, -1 };
            List<int> expectedProduct4 = new List<int> { 7, 1, 4 };


            List<int> product1 = Exercise215.MultiplyTwoNumbersDigits(firstFactor1, secondFactor1);
            List<int> product2 = Exercise215.MultiplyTwoNumbersDigits(firstFactor2, secondFactor2);
            List<int> product3 = Exercise215.MultiplyTwoNumbersDigits(firstFactor3, secondFactor3);
            List<int> product4 = Exercise215.MultiplyTwoNumbersDigits(firstFactor4, secondFactor4);


            Assert.AreEqual(expectedProduct1, product1);
            Assert.AreEqual(expectedProduct2, product2);
            Assert.AreEqual(expectedProduct3, product3);
            Assert.AreEqual(expectedProduct4, product4);
        }


        [Test]
        public void AddTwoNumbersDigitsTest()
        {
            List<int> firstAddend = new List<int> { 3, 5 };
            List<int> secondAddend = new List<int> { 8, 3 };
            List<int> expectedSumm = new List<int> { 1, 1, 8 };

            List<int> firstAddend1 = new List<int> { 0 };
            List<int> secondAddend1 = new List<int> { 1, 9 };
            List<int> expectedSumm1 = new List<int> { 1, 9 };

            List<int> firstAddend2 = new List<int> { 2, 3 };
            List<int> secondAddend2 = new List<int> { 0 };
            List<int> expectedSumm2 = new List<int> { 2, 3 };

            List<int> firstAddend3 = new List<int> { 2 };
            List<int> secondAddend3 = new List<int> { 9, 9, 9 };
            List<int> expectedSumm3 = new List<int> { 1, 0, 0, 1 };

            List<int> firstAddend4 = new List<int> { -2 };
            List<int> secondAddend4 = new List<int> { -9, -9, -9 };
            List<int> expectedSumm4 = new List<int> { -1, 0, 0, -1 };

            List<int> firstAddend5 = new List<int> { -2 };
            List<int> secondAddend5 = new List<int> { 9, 9, 9 };
            List<int> expectedSumm5 = new List<int> { 9, 9, 7 };

            List<int> firstAddend6 = new List<int> { 2 };
            List<int> secondAddend6 = new List<int> { -9, -9, -9 };
            List<int> expectedSumm6 = new List<int> { -9, -9, -7 };

            List<int> firstAddend7 = new List<int> { 0 };
            List<int> secondAddend7 = new List<int> { -9, -9, -9 };
            List<int> expectedSumm7 = new List<int> { -9, -9, -9 };

            // В отсутствие этого тесткейса проскочила ошибка в нескольких методах        
            List<int> firstAddend8 = new List<int> { 3, 5 };
            List<int> secondAddend8 = new List<int> { -2, -7 };
            List<int> expectedSumm8 = new List<int> { 8 };


            List<int> sum = Exercise215.AddTwoNumbersDigits(firstAddend, secondAddend);
            List<int> sum1 = Exercise215.AddTwoNumbersDigits(firstAddend1, secondAddend1);
            List<int> sum2 = Exercise215.AddTwoNumbersDigits(firstAddend2, secondAddend2);
            List<int> sum3 = Exercise215.AddTwoNumbersDigits(firstAddend3, secondAddend3);
            List<int> sum4 = Exercise215.AddTwoNumbersDigits(firstAddend4, secondAddend4);
            List<int> sum5 = Exercise215.AddTwoNumbersDigits(firstAddend5, secondAddend5);
            List<int> sum6 = Exercise215.AddTwoNumbersDigits(firstAddend6, secondAddend6);
            List<int> sum7 = Exercise215.AddTwoNumbersDigits(firstAddend7, secondAddend7);
            List<int> sum8 = Exercise215.AddTwoNumbersDigits(firstAddend8, secondAddend8);


            Assert.AreEqual(expectedSumm, sum);
            Assert.AreEqual(expectedSumm1, sum1);
            Assert.AreEqual(expectedSumm2, sum2);
            Assert.AreEqual(expectedSumm3, sum3);
            Assert.AreEqual(expectedSumm4, sum4);
            Assert.AreEqual(expectedSumm5, sum5);
            Assert.AreEqual(expectedSumm6, sum6);
            Assert.AreEqual(expectedSumm7, sum7);
            Assert.AreEqual(expectedSumm8, sum8);
        }


        [Test]
        public void SubtractTwoNumbersDigitsTest()
        {
            List<int> minuend = new List<int> { 0 };
            List<int> subtrahend = new List<int> { 0 };
            List<int> expectedDiffernce = new List<int> { 0 };

            List<int> minuend1 = new List<int> { 0 };
            List<int> subtrahend1 = new List<int> { 1, 2, 3 };
            List<int> expectedDiffernce1 = new List<int> { -1, -2, -3 };

            List<int> minuend2 = new List<int> { 1, 4 };
            List<int> subtrahend2 = new List<int> { 1, 8 };
            List<int> expectedDiffernce2 = new List<int> { -4 };

            List<int> minuend3 = new List<int> { 9, 9 };
            List<int> subtrahend3 = new List<int> { -2 };
            List<int> expectedDiffernce3 = new List<int> { 1, 0, 1 };

            List<int> minuend4 = new List<int> { -7, -7 };
            List<int> subtrahend4 = new List<int> { 2, 4 };
            List<int> expectedDiffernce4 = new List<int> { -1, 0, -1 };

            List<int> minuend5 = new List<int> { -3, -3 };
            List<int> subtrahend5 = new List<int> { -2, -9 };
            List<int> expectedDiffernce5 = new List<int> { -4 };


            List<int> difference = Exercise215.SubtractTwoNumbersDigits(minuend, subtrahend);
            List<int> difference1 = Exercise215.SubtractTwoNumbersDigits(minuend1, subtrahend1);
            List<int> difference2 = Exercise215.SubtractTwoNumbersDigits(minuend2, subtrahend2);
            List<int> difference3 = Exercise215.SubtractTwoNumbersDigits(minuend3, subtrahend3);
            List<int> difference4 = Exercise215.SubtractTwoNumbersDigits(minuend4, subtrahend4);
            List<int> difference5 = Exercise215.SubtractTwoNumbersDigits(minuend5, subtrahend5);


            Assert.AreEqual(expectedDiffernce, difference);
            Assert.AreEqual(expectedDiffernce1, difference1);
            Assert.AreEqual(expectedDiffernce2, difference2);
            Assert.AreEqual(expectedDiffernce3, difference3);
            Assert.AreEqual(expectedDiffernce4, difference4);
            Assert.AreEqual(expectedDiffernce5, difference5);
        }

    }
}
