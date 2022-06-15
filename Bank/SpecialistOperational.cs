using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class SpecialistOperational : BankEmployee
    {
        public SpecialistOperational(string firstName, string lastName, int birthYear) : base(firstName, lastName, birthYear)
        {
        }

        public override string GetInfo()
        {
            return $"Opeartional cash working specialist\n" +
                $"{base.GetInfo()}";
        }
    }
}
