using Evaluacion_II.Data.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Evaluacion_II.Interfaces
{
    internal interface IBankAccountBuilder<T>
    {
        IBankAccountBuilder<T> SetIdentification(int identification);
        IBankAccountBuilder<T> SetBalance(float balance);
        IBankAccountBuilder<T> SetAccountNumber(int accountNumber);
        IBankAccountBuilder<T> SetStatus(AccountStatus status);
        T Build();
    }
}
