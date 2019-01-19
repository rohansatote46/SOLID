using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsiblePrinciple.Interface
{
    interface IBankAccount
    {
        string AccountNumber { get; set; }
        decimal AccountBalance { get; set; }
    }
}
