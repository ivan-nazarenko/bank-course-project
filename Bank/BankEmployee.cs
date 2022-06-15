using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal abstract class BankEmployee
    {
        private const int MIN_BIRTH_YEAR = 1900;

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        private int birthYear;
        public int BirthYear { 
            get { return birthYear; } 
            private set
            {
                if (value < MIN_BIRTH_YEAR || value > DateTime.Now.Year)
                {
                    throw new ArgumentException("Incorrect birth year!");
                }

                birthYear = value;
            }
        }

        public BankEmployee(string firstName, string lastName, int birthYear)
        {
            FirstName = firstName;
            LastName = lastName;
            this.birthYear = birthYear;
        }

        public virtual string GetInfo()
        {
            return $"{FirstName} {LastName}, {BirthYear}";
        }

    }
}
