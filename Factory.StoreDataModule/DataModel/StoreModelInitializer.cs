﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Infrastructure;

namespace Factory.StoreDataModule.DataModel
{
    public class StoreModelInitializer : CreateDatabaseIfNotExists<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            context.Shoppers.Add(new Shopper()
            {
                Name = "test",
                Address = "address",
                ObjectState = ObjectState.Added
            });
            context.SaveChanges();
        }
    }
}
