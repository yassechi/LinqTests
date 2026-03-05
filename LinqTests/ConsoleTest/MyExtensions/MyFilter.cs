using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeedData;

namespace ConsoleTest.MyExtensions
{
    public static class MyFilter
    {
        public static List<Customer> getByName(this List<Customer> list, string name)
        {
            foreach (var item in list)
            {
                if (item.name.Contains(name.ToLower()))
                {
                    Console.WriteLine(item.name);
                }
            }
            return (GetData.GetCustomers().Where(c => c.name.Contains(name.ToLower()))).ToList();
        }


    }
}
