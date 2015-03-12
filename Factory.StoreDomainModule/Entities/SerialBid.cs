using System;
using System.Collections.Generic;

namespace Factory.StoreDomainModule.Entities
{
    public partial class SerialBid : EntityBase
    {
        public SerialBid()
        {
            this.BidDetails = new List<SerialBidDetail>();
        }

        public int ShopperId { get; set; }
        public Nullable<int> EmployeeId { get; set; }
        public Nullable<System.DateTime> BidDate { get; set; }
        public Nullable<System.DateTime> RequiredDate { get; set; }
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public Nullable<int> ShipVia { get; set; }
        public Nullable<decimal> Freight { get; set; }
        public string ShipName { get; set; }
        public string ShipAddress { get; set; }
        public string ShipCity { get; set; }
        public string ShipRegion { get; set; }
        public string ShipPostalCode { get; set; }
        public string ShipCountry { get; set; }
        public virtual Shopper Shopper { get; set; }
        public virtual ICollection<SerialBidDetail> BidDetails { get; set; }
    }
}
