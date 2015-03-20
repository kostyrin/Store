using System;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Factory.StoreWeb.Models.Bids
{
    public class BidModel
    {
        public BidModel()
        {
            Details = new List<BidDetailModel>();
        }

        public long BidId { get; set; }
        public int ShopperId { get; set; }
        public IEnumerable<SelectListItem> Shoppers { get; set; }
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

        public virtual IEnumerable<BidDetailModel> Details { get; set; }

        public class BidDetailModel
        {
            public long BidId { get; set; }
            public long BidDetailId { get; set; }
            public int ProductId { get; set; }
            public string ProductName { get; set; }
            public string VendorName { get; set; }
            public decimal UnitPrice { get; set; }
            public short Quantity { get; set; }
            public float Discount { get; set; }
        }
    }
}