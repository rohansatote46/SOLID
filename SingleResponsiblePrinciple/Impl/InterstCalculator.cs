using SingleResponsiblePrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblePrinciple.Impl
{
    class InterstCalculator : IInterstCalculator
    {
        public decimal CalculateInterest(IBankAccount account)
        {
            return 1000;
        }
    }
}
