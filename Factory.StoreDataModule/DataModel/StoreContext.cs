using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Factory.StoreDomainModule.Entities;
using Repository.Pattern.Ef6;

namespace Factory.StoreDataModule.DataModel
{
    public partial class StoreContext : DataContext
    {
        public StoreContext() : base("Name=StoreContext")
        {
            Database.SetInitializer(new StoreModelInitializer());
        }

        public DbSet<SerialCategory> SerialCategories { get; set; }
        public DbSet<Shopper> Shoppers { get; set; }
        public DbSet<SerialBidDetail> SerialBidDetails { get; set; }
        public DbSet<SerialBid> SerialBids { get; set; }
        public DbSet<SerialProduct> SerialProducts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }
    }
}
