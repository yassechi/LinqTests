using SeedData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeedData;

namespace ConsoleTest.MyExtensions
{
    public class MyFilter
    {
        public static IEnumerable<Customer> getAhmedCustomer()
        {
            var customers = GetData.GetCustomers().Where(c => c.name.Contains("ahmed"));
            return customers;
        }
    }
}
