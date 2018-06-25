using MvcAreaHosting.BaseModels.Merchant;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcAreaHosting.BaseModels
{
    public interface IMerchantSet
    {
        DbSet<ArticleSupplier> ArticleSuppliers { get; set; }
        DbSet<Article> Articles { get; set; }
        DbSet<ArticleTreeNode> ArticleTreeNodes { get; set; }

    }
}