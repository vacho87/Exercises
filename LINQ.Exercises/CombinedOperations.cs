using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ.Exercises
{
    /// <summary>
    /// These tests require the combination of various linq methods to arrive at a solution.
    /// Hints as to what these methods are will not be given. The student is required to think 
    /// critically above the problem in hand, and to utilise the full gamut of all the methods
    /// available to him or her.
    /// </summary>

    
    [TestClass]
    public class CombinedOperations
    {
        // we have a list of people
        // we have their first names
        // i need you to find out which letters are common
        // to all the first names

        // Hint: try to use set operations.
        // There are many ways to solve this.
        [TestMethod]
        public void GetCharactersCommonToEveryonesFirstNamesUsingSetElements_ReturnCharEnumerable()
        {
            IEnumerable<char> commonCharacters = TestData.People
                                                         .Select(person => person.FirstName.AsEnumerable())
                                                         .Aggregate((name, nextName) => name.Intersect(nextName))
                                                         .ToList();

            Assert.IsTrue(commonCharacters.OrderBy(x => x).SequenceEqual(new char[] { 'J' }.OrderBy(x => x)));
        }

        // Bonus Question
        // we have a list of people
        // we have their first names
        // i need you to find out which letters are common
        // to all the first names names
        // But you are not allowed to use set operations.
        [TestMethod]
        public void GetCharactersCommonToEveryonesFirstNamesNotUsingSetOperations_ReturnCharEnumerable()
        {            
            IEnumerable<IEnumerable<char>> names = TestData.People.Select(person => person.FirstName.ToCharArray());      
            IEnumerable<char> result = names.Aggregate((name, nextName) => name.Where(nextName.Contains));

            Assert.IsTrue(result.OrderBy(x => x).SequenceEqual(new char[] { 'J' }.OrderBy(x => x)));
        }

    }

}
