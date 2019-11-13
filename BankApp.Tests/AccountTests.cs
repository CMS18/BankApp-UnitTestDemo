using System;
using BankApp.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankApp.Tests
{
    [TestClass]
    public class AccountTests
    {
        [TestMethod]
        public void AccountHasBalance()
        {
            // Arrange
            decimal expectedBalance = 123.54m;
            var account = new Account(123.54m);

            // Act
            var actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        public void CanDepositAndBalanceIsCorrect()
        {
            // Arrange
            decimal initialBalanse = 123.54m;
            decimal depositAmount = 50m;
            decimal expectedBalance = 173.54m;

            var account = new Account(initialBalanse);

            // Act
            account.Deposit(depositAmount);
            var actualBalance = account.Balance;

            // Assert
            Assert.AreEqual(expectedBalance, actualBalance);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void CanNotDepositNegativeAmount()
        {
            // Arrange
            decimal initialBalanse = 123.54m;
            decimal depositAmount = -50m;

            var account = new Account(initialBalanse);

            // Act
            account.Deposit(depositAmount);

            // Assert
            // Expects ArgumentOutOfRangeException
        }
    }
}
