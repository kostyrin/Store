using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Repositories;

namespace Factory.StoreDataModule.Repositories
{
    public static class BidRepository
    {
        public static SerialBid GetBidById(this IRepository<SerialBid> repository, int bidId)
        {
            return repository.Queryable().FirstOrDefault(s => s.Id == bidId);
        }
        public static IEnumerable<SerialBid> GetBids(this IRepository<SerialBid> repository)
        {
            return repository.Queryable();
        }
    }
}
