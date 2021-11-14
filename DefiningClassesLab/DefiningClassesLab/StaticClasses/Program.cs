using System;

namespace StaticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            //BankHelper.Name = "OBB";
            //BankHelper.CalculateDebt(55);

            //Account account = new Account();
            //account.Balance = 100;
            //Account.Tax = 500; // vikame go na klasa
            //account.PayTax(); // -400

            Account account = new Account();
            account.Balance = 100;
            account.PayTax();
            Account account2 = new Account();
            account2.Balance = 1000;
            Account.Tax = 500;
            account.PayTax();
            account2.PayTax();

            Console.WriteLine(Account.GetBankName());
        }
    }
}
