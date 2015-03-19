using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Factory.StoreDataModule.Repositories;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace Factory.StoreServicesModule.Services
{
    public interface IBidService : IService<SerialBid>
    {
        IEnumerable<SerialBid> GetBids();
        SerialBid GetBidById(int bidId);
    }

    public class BidService : Service<SerialBid>, IBidService
    {
        private readonly IRepositoryAsync<SerialBid> _repository;
        

        public BidService(IRepositoryAsync<SerialBid> repository) : base(repository)
        {
            _repository = repository;
        }

        public IEnumerable<SerialBid> GetBids()
        {
            return _repository.GetBids();
        }

        public SerialBid GetBidById(int bidId)
        {
            return _repository.GetBidById(bidId);
        }
    }
}
