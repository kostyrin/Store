using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDataModule.DataModel;
using Factory.StoreDomainModule.Models;
using Repository.Pattern.Infrastructure;

namespace Factory.StoreConsoleModule
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StoreContext())
            {
                Customer find = context.Customers.FirstOrDefault(x => x.CustomerID == 1);
                foreach (var customer in context.Customers)
                {
                    Console.WriteLine("customer {0}", customer);
                }
            }
        }
    }
}
