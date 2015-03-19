using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Practicum.Core.Factories;
using Practicum.Core.Parsers;


namespace Practicum.Tests
{
    /// <summary>
    /// Tests to validate morning orders 
    /// </summary>
    [TestClass]
    public class InOrderToValidateMorningOrders
    {
        #region Morning Tests

        [TestMethod]
        public void When_IsMorningAndOrder123_Then_ReturnEggsToastCoffee()
        {
            string input = "morning, 1, 2, 3";
            string expectedOutput = "eggs, toast, coffee";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void When_IsMorningAndOrder213_Then_ReturnEggsToastCoffee()
        {
            string input = "morning, 2, 1, 3";
            string expectedOutput = "eggs, toast, coffee";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void When_IsMorningAndOrder1234_Then_ReturnEggsToastCoffeeError()
        {
            string input = "morning, 1, 2, 3, 4";
            string expectedOutput = "eggs, toast, coffee, error";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void When_IsMorningAndOrder12333_Then_ReturnEggsToastCoffee3Times()
        {
            string input = "morning, 1, 2, 3, 3, 3";
            string expectedOutput = "eggs, toast, coffee(x3)";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        }

        [TestMethod]
        public void When_IsMorningAndOrder12233_Then_ReturnEggsToastError()
        {
            string input = "morning, 1, 2, 2, 3, 3";
            string expectedOutput = "eggs, toast, error";

            BaseDishParser dishParser = DishParserFactory.GetDishParser(input);

            string producedOutput = dishParser.Parse();

            Assert.AreEqual(expectedOutput, producedOutput);
        } 
        #endregion     
    }
}
