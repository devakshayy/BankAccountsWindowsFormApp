using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BankAccountsApp
{
    internal class BankAccount
    {

        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string Owner)
        {
            this.Owner = Owner;
            this.AccountNumber = Guid.NewGuid();
            this.Balance = 0;
        }
        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "You Can't Deposit $" + amount;
            if (amount > 20000)
                return "AML Deoposit Limit Reached";
            Balance += amount;
            return "Deposit Completed Successfully";
        }
        public string WithDraw(decimal amount)
        {
            if (amount <= 0)
                return "You Can't Deposit $" + amount;
            if (amount > Balance)
                return "You Don't Have Enough Money";
            Balance -= amount;
            return "Withdraw Completed Successfully";
        }
    }
}
