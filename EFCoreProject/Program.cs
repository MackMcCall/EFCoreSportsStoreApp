// See https://aka.ms/new-console-template for more information
using EFCoreProject.Models;

Console.WriteLine("Hello, World!");
var context = new HplusSportsContext();
var salesPeopleS = context.Salespeople.Where(s => s.LastName.StartsWith("S"));
salesPeopleS.ToList().ForEach(s => Console.WriteLine(s.FirstName + " " + s.LastName));
Console.ReadKey();
