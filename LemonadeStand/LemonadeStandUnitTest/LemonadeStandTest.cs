using System;
using LemonadeStand;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LemonadeStandUnitTest
{
    [TestClass]
    public class LemonadeStandTest
    {
        [TestMethod]
        public void Test_GetDay_Zero()
        {
            News news = new News();
            //Arrange
            Day day = new Day(0);
            string expected = $"Day 1: Sunday";
            string result;
            //Act
            result = news.GetDay(day);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_GetDay_Eight()
        {
            News news = new News();
            //Arrange
            Day day = new Day(7);
            string expected = $"Day 8: There was an error in processing your request";
            string result;
            //Act
            result = news.GetDay(day);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_GetDay_Negative()
        {
            News news = new News();
            //Arrange
            Day day = new Day(-5);
            string expected = $"Day -4: There was an error in processing your request";
            string result;
            //Act
            result = news.GetDay(day);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void Test_DetermineEnoughMoney_False()
        {
            Store store = new Store();
            //Arrange
            double expense = 5;
            double playerMoney = 3;
            bool result;
            //Act
            result = store.DetermineEnoughMoney(expense, playerMoney);
            //Assert
            Assert.AreEqual(false, result);
        }
        [TestMethod]
        public void Test_DetermineEnoughMoney_Equals()
        {
            Store store = new Store();
            //Arrange
            double expense = 5;
            double playerMoney = 5;
            bool result;
            //Act
            result = store.DetermineEnoughMoney(expense, playerMoney);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_DetermineEnoughMoney_True()
        {
            Store store = new Store();
            //Arrange
            double expense = 5;
            double playerMoney = 10;
            bool result;
            //Act
            result = store.DetermineEnoughMoney(expense, playerMoney);
            //Assert
            Assert.AreEqual(true, result);
        }
        [TestMethod]
        public void Test_MoneyAfterExpense()
        {
            //Arrange
            Game game = new Game();
            game.SetInitialSupplies();
            int item = 0;
            int amount = 5;
            double expense = game.player.inventory.supplies[0].Price * amount;
            double expectedResult = game.player.inventory.Money - expense;
            //Act
            game.player.BuyIngredients(item, amount, expense);

            //Assert
            Assert.AreEqual(expectedResult, game.player.inventory.Money);
        }
        [TestMethod]
        public void Test_LemonQuantityAfterBuy()
        {
            //Arrange
            Game game = new Game();
            game.SetInitialSupplies();
            int item = 0;
            int amount = 5;
            double expense = game.player.inventory.supplies[0].Price * amount;
            //Act
            game.player.BuyIngredients(item, amount, expense);
            //Assert
            Assert.AreEqual(amount, game.player.inventory.supplies[item].Quantity);
        }
    }
}
