using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDataModule.DataModel;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Infrastructure;

namespace Factory.StoreConsoleModule
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StoreContext())
            {
                Shopper find = context.Shoppers.FirstOrDefault(x => x.Id == 1);
                foreach (var shopper in context.Shoppers)
                {
                    Console.WriteLine("shopper {0}", shopper);
                }
            }
        }
    }
}
