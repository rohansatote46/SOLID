using SingleResponsiblePrinciple.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblePrinciple
{
    class BankAccount : IBankAccount
    {
        public string AccountNumber { get; set; }
        public decimal AccountBalance { get; set; }
    }
}
