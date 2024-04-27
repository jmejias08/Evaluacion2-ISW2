using Evaluacion_II.Data.Enum;
using Evaluacion_II.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion_II.Models
{
    internal class BankAccountDirector
    {
        public BankAccount BuildBasicAccount(IBankAccountBuilder<BankAccount> builder)
        {
            return builder
                .SetIdentification(123456789)
                .SetBalance(0)
                .SetAccountNumber(987654321)
                .SetStatus(AccountStatus.Active)
                .Build();
        }

        public BankAccount BuildPremiumAccount(IBankAccountBuilder<BankAccount> builder)
        {
            return builder
                .SetIdentification(987654321)
                .SetBalance(10000) // Starting with a balance of $10,000 for a premium account
                .SetAccountNumber(123456789)
                .SetStatus(AccountStatus.Active)
                .Build();
        }
    }
}
