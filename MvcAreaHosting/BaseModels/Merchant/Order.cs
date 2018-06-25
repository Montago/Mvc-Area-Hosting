using MvcAreaHosting.BaseModels.Accounting;
using MvcAreaHosting.BaseModels.Addressing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Merchant
{
    [Table("Order", Schema = "Merchant")]
    public class OrderHead
    {
        [Key]
        public int HeadID { get; set; }

        [ForeignKey("Customer")]
        public int CustomerID { get; set; }

        [ForeignKey("DeliveryAddress")]
        public int DeliveryAddressID { get; set; }

        [ForeignKey("BillingAddress")]
        public int BillingAddressID { get; set; }

        #region Navigation
        public Address DeliveryAddress { get; set; }

        public Address BillingAddress { get; set; }

        public Customer Customer { get; set; }

        [CascadeDelete]
        public virtual ICollection<OrderLine> Orderlines { get; set; } 
        #endregion
    }

    [Table("OrderLine", Schema = "Merchant")]
    public class OrderLine
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

        #region Navigation
        public Article Article { get; set; }
        
        [ForeignKey("HeadID")]
        public OrderHead OrderHead { get; set; } 
        #endregion
    }
}