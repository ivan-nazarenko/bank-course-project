using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Group
    {
        public string Name { get; private set; }

        public List<Sector> Sectors { get; private set; }
        public List<HeadOfSector> HeadsOfSector { get; private set; }

        public Group(string name)
        {
            Name = name;
            Sectors = new List<Sector>();
            HeadsOfSector = new List<HeadOfSector>();
        }

        public void AddSector(int id, string name)
        {
            Sectors.Add(new Sector(id, name));
        }

        private Sector getSectorById(int id)
        {
            var sector = Sectors.Find(sector => sector.Id == id);
            if (sector == null)
            {
                throw new Exception("Sector does not exist!");
            }

            return sector;
        }

        private HeadOfSector getHeadBySectorId(int id)
        {
            var head = HeadsOfSector.Find(head => head.Sector.Id == id);
            if (head == null)
            {
                throw new Exception("Head of sector does not exist!");
            }

            return head;
        }

        private HeadOfSector getHeadOfSectorByLastName(string lastName)
        {
            var head = HeadsOfSector.Find(head => head.LastName == lastName);
            if (head == null)
            {
                throw new Exception("Head of sector does not exist!");
            }

            return head;
        }

        public string GetHeadsEmployees(string lastName)
        {
            var head = getHeadOfSectorByLastName(lastName);
            var sb = new StringBuilder();
            sb.AppendLine(head.GetInfo()).AppendLine();
            sb.AppendLine("Employees:").AppendLine();
            sb.Append(head.Sector.GetAllEmployeesInfo());

            return sb.ToString();
        }

        public void AddHeadOfSector(string firstName, string lastName, int birthYear, int sectorId)
        {
            var sector = getSectorById(sectorId);
            HeadsOfSector.Add(new HeadOfSector(sector, firstName, lastName, birthYear));
        }

        public void AddSectorEmployee(string firstName, string lastName, int birthYear, int sectorId, EmployeeKind kind)
        {
            var sector = getSectorById(sectorId);
            switch (kind)
            {
                case EmployeeKind.Cahier:
                    sector.AddCashier(new Cashier(firstName, lastName, birthYear));
                    break;
                case EmployeeKind.SpecialistOperational:
                    sector.AddSpecialistOperational(new SpecialistOperational(firstName, lastName, birthYear));
                    break;
            }
        }

        public string GetSectorsInfo()
        {
            var sb = new StringBuilder("");

            foreach (var sector in Sectors)
            {
                sb.AppendLine(sector.GetInfo());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string GetHeadsInfo()
        {
            var sb = new StringBuilder("");

            foreach (var head in HeadsOfSector)
            {
                sb.AppendLine(head.GetInfo());
                sb.AppendLine();
            }

            return sb.ToString();
        }

        public string GetMinCashiers()
        {
            var resultSector = Sectors.First();
            foreach (var sector in Sectors)
            {
                if (sector.GetNumberOfCashiers() < resultSector.GetNumberOfCashiers())
                {
                    resultSector = sector;
                }
            }

            return $"{resultSector.GetInfo()}\n\n{resultSector.GetCashiers()}";
        }

        public string GetMaxCashiers()
        {
            var resultSector = Sectors.First();
            foreach (var sector in Sectors)
            {
                if (sector.GetNumberOfCashiers() > resultSector.GetNumberOfCashiers())
                {
                    resultSector = sector;
                }
            }

            return $"{resultSector.GetInfo()}\n\n{resultSector.GetCashiers()}";
        }
    }
}
