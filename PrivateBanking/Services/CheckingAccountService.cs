using PrivateBanking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PrivateBanking.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext db;

        public CheckingAccountService(ApplicationDbContext dbcontext)
        {
            db = dbcontext;
        }

        public void CreateCheckingAccount(string firstName, string lastName, string userId, decimal initialBalance)
        {
            // Following black of code insert new user to chekcingAccount table at database
            var accountNumber = (123456 + db.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var chekcingAccount = new CheckingAccount
            {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNumber,
                Balance = initialBalance,
                ApplicationUserId = userId
            };
            db.CheckingAccounts.Add(chekcingAccount);
            db.SaveChanges();
        }
    }
}