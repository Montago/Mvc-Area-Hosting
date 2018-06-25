using MvcAreaHosting.BaseModels.Addressing;
using MvcAreaHosting.BaseModels.Content;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Merchant
{
    [Table("Suppliers", Schema = "Merchant")]
    public class ArticleSupplier
    {
        [Key]
        public int SupplierID { get; set; }

        public string Name { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        public string Description { get; set; }

        public int AddressID { get; set; }
        
        [ForeignKey("AddressID")]
        public Address Address { get; set; }
    }

    [Table("Articles", Schema = "Merchant")]
    public partial class Article
    {
        [ForeignKey("Supplier")]
        [Key, Column(Order = 1)]
        public int SupplierID { get; set; }

        [Key, Column(Order = 2), MaxLength(100)]
        public string ArticleID { get; set; }

        [ForeignKey("Title")]
        public int TitleID { get; set; }

        [ForeignKey("Description")]
        public int DescriptionID { get; set; }

        [ForeignKey("TreeNode")]
        public int TreeNodeID { get; set; }

        #region Navigation properties
        public ArticleSupplier Supplier { get; set; }

        public Label Title { get; set; }

        public Label Description { get; set; }

        public ArticleTreeNode TreeNode { get; set; } 
        #endregion
    }

    [Table("ArticleTree", Schema = "Merchant")]
    public class ArticleTreeNode
    {
        [Key]
        public int TreeNodeID { get; set; }

        [ForeignKey("Parent")]
        public int ParentID { get; set; }

        [ForeignKey("Label")]
        public int LabelID { get; set; }

        #region Navigation properties
        public ArticleTreeNode Parent { get; set; }

        public Label Label { get; set; } 
        #endregion
    }
}