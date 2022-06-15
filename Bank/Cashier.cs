using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Cashier : BankEmployee
    {
        public Cashier(string firstName, string lastName, int birthYear) : base(firstName, lastName, birthYear)
        {
        }

        public override string GetInfo()
        {
            return $"Cashier\n" +
                $"{base.GetInfo()}";
        }
    }
}
