using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblePrinciple.Interface
{
    interface IInterstCalculator
    {
        decimal CalculateInterest(IBankAccount account);
    }
}
