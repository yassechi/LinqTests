using SeedData;
using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public static List<Customer> getByAge(this List<Customer> list,string name, int age)
        {
            return list.Where(c => c.age > age && c.name.Contains(name.ToLower())).ToList();
        }

        public static List<Customer> GetCustomers(this List<Customer> list, Func<Customer, bool> func)
        {
            List<Customer> result = new List<Customer>();
            foreach (var item in list)
            {
                if (func(item))
                {
                    result.Add(item);
                }
            }
            return result;
        } 


    }
}
