using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;

namespace LINQ.Exercises
{
    /// <summary>
    /// Your task is to apply LINQ `Count/Sum/Min/Max/Average/Aggregate` methods, so all tests will be passed.
    /// Make sure to preview test data located in TestData.cs file.
    /// Don't modify assertions or test data, all you need to do is to apply LINQ method so `result` variable will have expected value(s).
    /// </summary>
    [TestClass]
    public class Aggregate
    {
        [TestMethod]
        public void Count_all_numbers()
        {
            // First test is solved to show you how to use these exercises.
            int result = TestData.Numbers.Count();

            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void Count_all_occurences_of_1()
        {
            int result = TestData.Numbers.Count(number => number == 1);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Count_all_animals_having_character_count_equal_to_5()
        {
            // Hint: use nested count
            int result = TestData.Animals.Count(animal => animal.Count() == 5);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Sum_all_numbers()
        {           
            int result = TestData.Numbers.Sum();

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Sum_all_characters_in_animal_names()
        {
            int result = TestData.Animals.Sum(animal => animal.Length);

            Assert.AreEqual(38, result);
        }

        [TestMethod]
        public void Sum_all_birth_years()
        {
            int result = TestData.People.Sum(person => person.Born.Year);

            Assert.AreEqual(7915, result);
        }

        [TestMethod]
        public void Find_minimum_number()
        {
            int result = TestData.Numbers.Min();

            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void Find_length_of_shortest_animal_name()
        {
            int result = TestData.Animals.Min(animal => animal.Length);

            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void Find_earliest_birthday()
        {
            DateTime result = TestData.People.Min(person => person.Born.Date);

            Assert.AreEqual(new DateTime(1950, 12, 1), result);
        }

        [TestMethod]
        public void Find_maximum_number()
        {
            int result = TestData.Numbers.Max();

            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Find_length_of_longest_animal_name()
        {
            int result = TestData.Animals.Max(animal => animal.Length);

            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Find_latest_birthday()
        {

            // Первоначально строка ниже выглядела следующим образом: 
            // "DateTime result = TestData.People.First().Born;"
            // как и в некороых других упражнениях выше я ее и зменил принципиально и получил правильный результат
            // но у меня периодически возникает вопрос:
            // "а вдруг автор упражнения хотел чтобы упражнение было решено именно в рамках заданного им шаблона?"
            // а я хоть и доился нужного результата, но добился его не тем путем
            DateTime result = TestData.People.Max(person => person.Born);

            Assert.AreEqual(new DateTime(2001, 5, 21), result);
        }

        [TestMethod]
        public void Find_average_of_numbers()
        {
            double result = TestData.Numbers.Average();

            Assert.AreEqual(-0.2, result);
        }

        [TestMethod]
        public void Find_average_of_birth_years()
        {
            double result = TestData.People.Average(person => person.Born.Year);

            Assert.AreEqual(1978.75, result);
        }

        [TestMethod]
        public void Aggregate_Sum_of_all_numbers()
        {
            // Aggregate is a little bit more complicated
            // so first test is solved to show you how to use it.
            int result = TestData.Numbers.Aggregate((sum, nextValue) => sum + nextValue);

            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void Aggregate_Product_of_all_numbers()
        {
            // Hint: product is a result of multiplication
            int result = TestData.Numbers.Aggregate((product, nextValue) => product * nextValue);

            Assert.AreEqual(-1800, result);
        }

        [TestMethod]
        public void Aggregate_Secret_formula()
        {
            // secret formula is as follows
            // start with 256
            // for each person take the day of her/his birth date
            // if this day is bigger than 15, then substract 10 from it
            // else add 5 to it
            // and add resulting number to your aggregate
            int result = TestData.People.Aggregate(256, (sum, person) => sum + (person.Born.Day > 15 ? person.Born.Day - 10 : person.Born.Day + 5));

            Assert.AreEqual(296, result);
        }
    }
}