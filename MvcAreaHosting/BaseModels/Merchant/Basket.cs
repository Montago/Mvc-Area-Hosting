using MvcAreaHosting.BaseModels.Accounting;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Merchant
{
    [Table("Basket", Schema = "Merchant")]
    public class BasketHead
    {
        [Key]
        public int HeadID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        //-----------------------------------------------------------------

        #region Navigation
        public Customer Customer { get; set; }

        [CascadeDelete]
        public virtual ICollection<BasketLine> Basketlines { get; set; }
        #endregion
    }

    [Table("BasketLine", Schema = "Merchant")]
    public class BasketLine
    {
        #region PKEY
        [Key]
        public long LineID { get; set; } 
        #endregion

        #region FKEY
        [ForeignKey("Article"), Column(Order = 1)]
        public int SupplierID { get; set; }

        [ForeignKey("Article"), Column(Order = 2), MaxLength(100)]
        public string ArticleID { get; set; }

        public int HeadID { get; set; }
        #endregion

        #region Navigation properties
        public Article Article { get; set; }
        
        [ForeignKey("HeadID")]
        public BasketHead BasketHead { get; set; }
        #endregion
    }
}