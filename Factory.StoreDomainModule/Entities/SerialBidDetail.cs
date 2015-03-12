namespace Factory.StoreDomainModule.Entities
{
    public partial class SerialBidDetail : EntityBase
    {
        public int BidId { get; set; }
        public int ProductId { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }
        public virtual SerialBid Bid { get; set; }
        public virtual SerialProduct Product { get; set; }
    }
}
