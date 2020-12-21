using System;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise28Test
    {
        [Test]
        public void ReturnPowerOfTwoTest ()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> exeptedlist = new List<int> { 1, 4, 9 };
            Exercise28 Ex = new Exercise28();
            Ex.deleg = Ex.ReturnPowerOfTwo;


            List<int> processedList = Ex.On_All(list, Ex.deleg);


            Assert.AreEqual(exeptedlist, processedList);
        }

        [Test]
        public void ReturnPowerofThreeTest()
        {
            List<int> list = new List<int> { 1, 2, 3 };
            List<int> exeptedlist = new List<int> { 1, 8, 27 };
            Exercise28 Ex = new Exercise28();
            Ex.deleg = Ex.ReturnPowerofThree;


            List<int> processedList = Ex.On_All(list, Ex.deleg);


            Assert.AreEqual(exeptedlist, processedList);
        }

    }
}
