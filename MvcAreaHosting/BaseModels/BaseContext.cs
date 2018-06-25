using MvcAreaHosting.BaseModels;
using MvcAreaHosting.BaseModels.Accounting;
using MvcAreaHosting.BaseModels.Addressing;
using MvcAreaHosting.BaseModels.Content;
using MvcAreaHosting.BaseModels.Merchant;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace MvcAreaHosting.Models
{
    public abstract class BaseContext : DbContext
    {
        #region Merchant
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleSupplier> ArticleSuppliers { get; set; }
        public DbSet<ArticleTreeNode> ArticleTree { get; set; }

        public DbSet<BasketHead> Baskets { get; set; }
        public DbSet<BasketLine> BasketLines { get; set; }

        public DbSet<OrderHead> Orders { get; set; }
        public DbSet<OrderLine> OrderLines { get; set; }
        #endregion

        #region Localization
        public DbSet<Culture> Cultures { get; set; }
        public DbSet<Label> Labels { get; set; }
        #endregion

        #region Accounting
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CustomerAddress> CustomerAddresses { get; set; }
        #endregion

        #region Addressing
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Country> Countries { get; set; }
        #endregion

        public BaseContext(string ConnectionString) : base(ConnectionString)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Add<CascadeDeleteAttributeConvention>();

            //modelBuilder.Entity<Order>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Order");
            //});

            //modelBuilder.Entity<OrderLine>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("OrderLine");
            //});

            //modelBuilder.Entity<Basket>().Map(m => 
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("Basket");
            //});

            //modelBuilder.Entity<BasketLine>().Map(m =>
            //{
            //    m.MapInheritedProperties();
            //    m.ToTable("BasketLine");
            //});

            base.OnModelCreating(modelBuilder);
        }
    }
}