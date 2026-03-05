using ConsoleTest.MyExtensions;
using SeedData;
using SeedData.Models;

// Use Extensions
GetData.GetCustomers().getByName("Ahmed");

Console.WriteLine("----------------------------------------------------------");
// Custumers
var c1 = new Customer { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 };
var c2 = new Customer { id = 102, name = "salah ahmed", age = 32, isActive = false, joinDate = new DateTime(2023, 1, 3), categoryId = 1, spendAverage = 2500.9m, telephone = 987654321 };
//var c2 = c1;

Console.WriteLine(c1.Equals(c2));

Console.WriteLine("----------------------------------------------------------");
// Anonymus Type 
var c3 = new { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 };
var c5 = new { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 };
var c6 = new { id = 101, Custname = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m, telephone = 123456789 };
var c4 = new { id = 101, name = "ahmed mohmed", age = 30, isActive = true, joinDate = new DateTime(2022, 10, 15), categoryId = 1, spendAverage = 1500.9m };
Console.WriteLine(c3.GetType().Name);
Console.WriteLine(c4.GetType().Name);
Console.WriteLine(c3.Equals(c4));
Console.WriteLine(c3.Equals(c5));
Console.WriteLine(c5.Equals(c6)); // pas le meme type si une propriety change .. et si les value change !!
// pas pour les retours pas pour les parametres !!






