using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_ATMDEM.Models;

namespace MVC_ATMDEM.Services
{
    public class CheckingAccountService
    {

        private IApplicationDbContext db;

        public CheckingAccountService(IApplicationDbContext dbContext)
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

        public void UpdateBalance(int checkingAccountId)
        {
            var checkingAccount = db.CheckingAccounts.Where(c => c.Id == checkingAccountId).First();

            checkingAccount.Balance = db.Transactions.Where(a => a.CheckingAccountId == checkingAccountId).Sum(c => c.Amount);

            db.SaveChanges();
        }
    }
}