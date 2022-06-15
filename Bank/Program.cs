// See https://aka.ms/new-console-template for more information

using Bank;

var group = new Group("Hamlin, Hamlin & McGill");

group.AddSector(1, "Finances");
Console.WriteLine("Current Sectors:");
Console.WriteLine(group.GetSectorsInfo());

group.AddSector(2, "Investments");
Console.WriteLine("Current Sectors:");
Console.WriteLine(group.GetSectorsInfo());

group.AddHeadOfSector("Howard", "Hamlin", 1970, 1);
Console.WriteLine("Heads list:\n");
Console.WriteLine(group.GetHeadsInfo());

group.AddHeadOfSector("Chuck", "McGill", 1960, 2);
Console.WriteLine("Heads list:\n");
Console.WriteLine(group.GetHeadsInfo());

group.AddSectorEmployee("Jimmy", "McGill", 1972, 1, EmployeeKind.SpecialistOperational);
group.AddSectorEmployee("Kim", "Wexler", 1975, 1, EmployeeKind.Cahier);
group.AddSectorEmployee("Mike", "Ehrmantraut", 1940, 1, EmployeeKind.Cahier);

group.AddSectorEmployee("Nacno", "Varga", 1976, 2, EmployeeKind.SpecialistOperational);
group.AddSectorEmployee("Gustavo", "Fring", 1960, 2, EmployeeKind.Cahier);

Console.WriteLine("Search by 'Hamlin' last name: \n");
Console.WriteLine(group.GetHeadsEmployees("Hamlin"));

Console.WriteLine("Min Cashiers:\n");
Console.WriteLine(group.GetMinCashiers());

Console.WriteLine("Max Cashiers:\n");
Console.WriteLine(group.GetMaxCashiers());