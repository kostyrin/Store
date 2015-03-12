using System;

namespace Factory.StoreDataModule.Models
{
    public class SerialShopperBid
    {
        public int ShopperId { get; set; }
        public string ContactName { get; set; }
        public int BidId { get; set; }
        public DateTime? BidDate { get; set; }
    }
}