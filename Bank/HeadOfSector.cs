using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class HeadOfSector : BankEmployee
    {
        public Sector Sector { get; private set; }

        public HeadOfSector(Sector sector, string firstName, string lastName, int birthYear) : base(firstName, lastName, birthYear)
        {
            Sector = sector;
        }

        public override string GetInfo()
        {
            return $"Head of {Sector.Name}\n" +
                $"{base.GetInfo()}";
        }
    }
}
