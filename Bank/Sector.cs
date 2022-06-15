using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Sector
    {
        public int Id { get; private set; }

        public string Name { get; private set; }

        public List<Cashier> Cashiers { get; private set; }

        public List<SpecialistOperational> SpecialistsOperational { get; private set; }

        public Sector(int id, string name)
        {
            Id = id;
            Name = name;
            Cashiers = new List<Cashier>();
            SpecialistsOperational = new List<SpecialistOperational>();
        }

        public string GetInfo()
        {
            return $"ID: {Id}; Name: {Name}";
        }

        public void AddCashier(Cashier cashier)
        {
           Cashiers.Add(cashier);
        }

        public void AddSpecialistOperational(SpecialistOperational specialistOperational)
        {
            SpecialistsOperational.Add(specialistOperational);
        }

        private List<BankEmployee> getAllEmployees()
        {
            var employees = new List<BankEmployee>();
            employees.Concat(Cashiers).Concat(SpecialistsOperational).ToList();

            return employees;
        }

        public int GetNumberOfCashiers()
        {
            return Cashiers.Count;
        }

        public int GetNumberOfSpecOperational()
        {
            return SpecialistsOperational.Count;
        }

        public string GetCashiers()
        {
            var sb = new StringBuilder();

            foreach (var cashier in Cashiers)
            {
                sb.AppendLine(cashier.GetInfo()).AppendLine();
            }

            return sb.ToString();
        }

        public string GetSpecialists()
        {
            var sb = new StringBuilder();

            foreach (var spec in SpecialistsOperational)
            {
                sb.AppendLine(spec.GetInfo()).AppendLine();
            }

            return sb.ToString();
        }

        public string GetAllEmployeesInfo()
        {
            return $"{GetCashiers()}\n{GetSpecialists()}";
        }
    }
}
