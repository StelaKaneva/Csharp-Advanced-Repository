using System;
using System.Collections.Generic;
using System.Text;

namespace StaticClasses
{
    class Account
    {
        public string Owner { get; set; }
        public decimal Balance { get; set; }

        public static decimal Tax { get; set; }

        public void PayTax()
        {
            this.Balance -= Account.Tax;
        }

        public static string GetBankName()
        {
            return "OBB";
        }
    }
}
