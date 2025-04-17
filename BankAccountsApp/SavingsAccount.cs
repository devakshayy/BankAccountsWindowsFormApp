using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountsApp
{
    internal class SavingsAccount:BankAccount
    {
        decimal InterestRate { get; set; }
        public SavingsAccount(string Owner, decimal InterestRate):base(Owner + "("+InterestRate+"%)")
        {
            this.InterestRate = InterestRate;
        }
    }
}
