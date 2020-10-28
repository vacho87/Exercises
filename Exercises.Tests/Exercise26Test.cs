using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise26Test
    {
        [Test]
        public void IsAStringAPalindromeTest ()
        {
            string str = "wow";
            Assert.IsTrue(Exercise26.IsAStringAPalindrome(str));

            string str2 = "now";
            Assert.IsFalse(Exercise26.IsAStringAPalindrome(str2));

        }
    }
}
