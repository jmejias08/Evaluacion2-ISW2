using Evaluacion_II.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.Generic;

namespace Evaluacion_II.Models
{
    internal class BankAccount
    {
        public int Id { get; set; }
        public int Identification { get; set; }
        public float Balance { get; set; }
        public int AccountNumber { get; set; }
        public AccountStatus Status { get; set; }

        public BankAccount()
        {

        }

        public BankAccount(int id, int identification, float balance, int accountNumber, AccountStatus status)
        {
            Id = id;
            Identification = identification;
            Balance = balance;
            AccountNumber = accountNumber;
            Status = status;
        }
    }

    internal enum AccountStatus
    {
        Active,
        Inactive
    }

    internal class BankAccountManager
    {
        public List<BankAccount> GetBankAccounts()
        {
          
            List<BankAccount> bankAccounts = new List<BankAccount>
            {
                new BankAccount(1, 205370796, 17568.00f, 100200, AccountStatus.Active),
                new BankAccount(2, 205370796, 1350500.00f, 100201, AccountStatus.Active),
                new BankAccount(3, 108890456, 560000.00f, 100950, AccountStatus.Active),
                new BankAccount(4, 108890456, 235000.00f, 100951, AccountStatus.Inactive),
                new BankAccount(5, 304560987, 150355.00f, 100600, AccountStatus.Active)
            };

            return bankAccounts;
        }
    }
}
