using System;
using System.Collections.Generic;

namespace Factory.StoreDomainModule.Entities
{
    public partial class SerialProduct : EntityBase
    {
        public SerialProduct()
        {
            this.BidDetails = new List<SerialBidDetail>();
        }

        public string ProductName { get; set; }
        public Nullable<int> SupplierId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public int QuantityPerUnit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public Nullable<short> UnitsInStock { get; set; }
        public Nullable<short> UnitsOnOrder { get; set; }
        public Nullable<short> ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public virtual SerialCategory Category { get; set; }
        public virtual ICollection<SerialBidDetail> BidDetails { get; set; }
    }
}
