using MvcAreaHosting.BaseModels;
using MvcAreaHosting.BaseModels.Merchant;
using MvcAreaHosting.Models;
using System.Data.Entity;
using System.Data.Entity.Migrations;

namespace MvcAreaHosting.Areas.DomainArea1.Models
{
    public class DomainArea1Context : BaseContext
    {
        /*****************************************************************
         * Override the Article set with the Improved Article class. 
         *****************************************************************/
        public new DbSet<BetterArticle> Articles { get; set; }


        public DomainArea1Context() : base("DomainArea1Context")
        {
            
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }

    public class DomainArea1Configuration : DbMigrationsConfiguration<DomainArea1Context>
    {
        public DomainArea1Configuration()
        {
            AutomaticMigrationsEnabled = false;

            this.MigrationsDirectory = "Areas\\DomainArea1\\Migrations";
            this.MigrationsNamespace = "Migrations.DomainArea1";
        }

        protected override void Seed(DomainArea1Context context)
        {
            //  DbSet<T>.AddOrUpdate()
        }
    }

    /*****************************************************************
       Inherit and Improve Article class
   *****************************************************************/
    public class BetterArticle : Article
    {
        public int OneMoreProp { get; set; }
    }

}