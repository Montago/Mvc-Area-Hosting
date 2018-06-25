using MvcAreaHosting.BaseModels;
using MvcAreaHosting.BaseModels.Merchant;
using MvcAreaHosting.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MvcAreaHosting.Areas.Wissenberg.Models
{
    /*****************************************************************
        Inherit and Improve Article class
    *****************************************************************/
    public class BetterArticle : Article
    {
        public int OneMoreProp { get; set; }
    }

    public class WissenbergContext : BaseContext
    {
        /*****************************************************************
         * Override the Article set with the Improved Article class. 
         *****************************************************************/
        public new DbSet<BetterArticle> Articles { get; set; }


        public WissenbergContext() : base("WissenbergContext")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class WissenbergConfiguration : DbMigrationsConfiguration<WissenbergContext>
    {
        public WissenbergConfiguration()
        {
            AutomaticMigrationsEnabled = false;

            this.MigrationsDirectory = "Areas\\Wissenberg\\Migrations";
            this.MigrationsNamespace = "Migrations.Wissenberg";
        }

        protected override void Seed(WissenbergContext context)
        {
            //  DbSet<T>.AddOrUpdate()
        }
    }
}