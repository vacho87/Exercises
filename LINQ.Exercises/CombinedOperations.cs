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

    // Почему-то методы этого класса не отображаются в ТестЭксплорере
    // но в случае копирования в другой класс, например в SetOperations все исправно работает
    [TestClass]
    class CombinedOperations
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
            // считаю, что задача мной решена, а тест не проходит из-за того, что ожидаемый результат запроса в блоке Assert
            // "new char[] { 'a', 'i', 'J' }" указан неверно, точнее он не соответствует словесной постановке задачи:
            // для всех четырех FirstName в источнике данных общей является лишь буква 'J'
            IEnumerable<IEnumerable<char>> names = TestData.People.Select(person => person.FirstName.ToCharArray());
            IEnumerable<char> commonCharacters = names.Aggregate((name, nextName) => name.Intersect(nextName)); // please edit/complete so that the test passes

            // Вариант в одно выражение, но он как-то слишком сложно читается
            // IEnumerable<char> commonCharacters = TestData.People.Select(person => (IEnumerable<char>)person.FirstName.ToCharArray()).Aggregate((name, nextName) => name.Intersect(nextName));

            Assert.IsTrue(commonCharacters.OrderBy(x => x).SequenceEqual(new char[] { 'a', 'i', 'J' }.OrderBy(x => x)));
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
            IEnumerable<char> result = names.Aggregate((name, nextName) => { 
                List<char> commLetters = new List<char>(); 
                foreach (char letter in name)
                {                    
                        if (nextName.Contains(letter)) commLetters.Add(letter);                   
                }
                return commLetters;
            });

            Assert.IsTrue(result.OrderBy(x => x).SequenceEqual(new char[] { 'a', 'i', 'J' }.OrderBy(x => x)));
        }

    }

}
