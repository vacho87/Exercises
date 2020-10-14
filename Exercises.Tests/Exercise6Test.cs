using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise6Test
    {
        [Test]
        public void SumTest ()
        {
            //Arrange
            Exercise6 ex = new Exercise6();
            //Act
            var sum = ex.Sum(5);
            //Assert
            Assert.AreEqual(sum, 15); 
        }

        [Test]
        public void ProductTest ()
        {
            //Arrange
            Exercise6 ex = new Exercise6();
            //Act
            var prod = ex.Product(5);
            //Assert
            Assert.AreEqual(prod, 120);
        }
    }
}
