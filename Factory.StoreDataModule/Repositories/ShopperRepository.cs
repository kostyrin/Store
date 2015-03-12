﻿using System.Collections.Generic;
using System.Linq;
using Factory.StoreDataModule.Models;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Repositories;

namespace Factory.StoreDataModule.Repositories
{
    // Exmaple: How to add custom methods to a repository.
    public static class ShopperRepository
    {
        public static decimal GetShopperBindTotalByYear(this IRepository<Shopper> repository, int shopperId, int year)
        {
            return repository
                .Queryable()
                .Where(c => c.Id == shopperId)
                .SelectMany(c => c.Bids.Where(o => o.BidDate != null && o.BidDate.Value.Year == year))
                .SelectMany(c => c.BidDetails)
                .Select(c => c.Quantity*c.UnitPrice)
                .Sum();
        }

        public static IEnumerable<Shopper> ShoppersByName(this IRepositoryAsync<Shopper> repository, string companyName)
        {
            return repository
                .Queryable()
                .Where(x => x.Name.Contains(companyName))
                .AsEnumerable();
        }

        public static IEnumerable<SerialShopperBid> GetShopperBids(this IRepository<Shopper> repository, string country)
        {
            var shoppers = repository.GetRepository<Shopper>().Queryable();
            var bids = repository.GetRepository<SerialBid>().Queryable();

            var query = from c in shoppers
                        join o in bids on new { a = c.Id, b = c.Country }
                            equals new { a = o.ShopperId, b = country }
                        select new SerialShopperBid
                        {
                            ShopperId = c.Id,
                            ContactName = c.ContactName,
                            BidId = o.Id,
                            BidDate = o.BidDate
                        };

            return query.AsEnumerable();
        }
    }
}