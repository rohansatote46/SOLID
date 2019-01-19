using SingleResponsiblePrinciple.Impl;
using System;

namespace SingleResponsiblePrinciple
{
    class Program: InterstCalculator
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount();
            ba.AccountBalance = 5000;
            ba.AccountNumber = "ROH001";
            Program p = new Program();
           var intrest = p.CalculateInterest(ba);
            Console.WriteLine("intrest: "+ intrest);
            Console.ReadKey();
        }
    }
}