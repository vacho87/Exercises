using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Exercises.Tests
{
    [TestFixture]
    class Exercise220Test
    {
        [Test]
        public void TestTranslateTextToPigLatin()
        {
            string text1 = "The quick brown fox";
            string text2 = "Hello world !";
            string expectedText1 = "Hetay uickqay rownbay oxfay";
            string expectedText2 = "Ellohay orldway !";


            string translatedText1 = Exercise220.TranslateTextToPigLatin(text1);
            string translatedText2 = Exercise220.TranslateTextToPigLatin(text2);


            Assert.AreEqual(expectedText1, translatedText1);
            Assert.AreEqual(expectedText2, translatedText2);
        }

    }

}
