using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise11
    {
        [Test]
        public void ExpressionValueCalcTest ()
        {
            decimal expectedResult = -0.0050251256281407035175879397m;
                       
            Assert.AreEqual(expectedResult, Exercises.Exercise11.ExpressionValueCalc(100));
        }

        [Test]
        public void ExpressionValueSmartCalcTest()
        {
            decimal expectedResult = -0.0025062656641604010025062657m;

            Assert.AreEqual(expectedResult, Exercises.Exercise11.ExpressionValueSmartCalc(200));
        }

        [Test]
        public void TheSmartestCalcTest()
        { 
            decimal expectedResult = 3.1415916535897932387126435740m;
                       
            Assert.AreEqual(expectedResult, Exercises.Exercise11.TheSmartestCalc(1000000));
        }
    }
}
