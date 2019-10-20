using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_ATMDEM.Models;

namespace MVC_ATMDEM.Services
{
    public class CheckingAccountService
    {

        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string UserId, decimal initialBalance)
        {
            var accountNUm = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount
            {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNUm,
                Balance = initialBalance,
                ApplicationUserId = UserId
            };
            db.CheckingAccounts.Add(checkingAccount);
            db.SaveChanges();
        }
    }
}