using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDomainModule.Models;
using Repository.Pattern.Infrastructure;

namespace Factory.StoreDataModule.DataModel
{
    public class StoreModelInitializer : CreateDatabaseIfNotExists<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            context.Customers.Add(new Customer()
            {
                CustomerID = 1,
                CompanyName = "test",
                Address = "address",
                ObjectState = ObjectState.Added
            });
            context.SaveChanges();
        }
    }
}
