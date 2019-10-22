using System;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVC_ATMDEM.Controllers;
using MVC_ATMDEM.Models;

namespace MVC_ATMDEM.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FooActionReturnsAboutView()
        {
            var homeco = new HomeController();

            var result = homeco.Foo() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void Contactsaysthanks()
        {
            var homeco = new HomeController();
            var result = homeco.Contact("I love your bank") as ViewResult;
            Assert.IsNotNull(result.ViewBag.Message);
        }

        [TestMethod]
        public void BalanceIsCorrectAfterDeposit()
        {
            var fakeDb = new FakeApplicationDbContext();
            fakeDb.CheckingAccounts = new FakeDbSet<CheckingAccount>();

            var checkingAccount = new CheckingAccount {Id = 1, AccountNumber = "000123TEST", Balance = 0};
            fakeDb.CheckingAccounts.Add(checkingAccount);


            var transactionController = new TransactionController(fakeDb);
            transactionController.Deposit(new Transaction {CheckingAccountId = 1, Amount = 25});

            Assert.AreEqual(25, checkingAccount.Balance);
        }


    }
}
