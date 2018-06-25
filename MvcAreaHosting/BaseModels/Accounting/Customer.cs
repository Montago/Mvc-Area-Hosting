using MvcAreaHosting.BaseModels.Addressing;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Accounting
{
    [Table("Customers", Schema = "Accounting")]
    public class Customer
    {
        public int CustomerID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        /// <summary>
        /// Password hashing
        /// </summary>
        public string HASH { get; set; }
        public string SALT { get; set; }

        public int CustomerAddressID { get; set; }

        [ForeignKey("CustomerAddressID")]
        public virtual ICollection<CustomerAddress> Addresses { get; set; }
    }

    [Table("CustomerAddress", Schema = "Accounting")]
    public class CustomerAddress
    {
        [Key]
        public int CustomerAddressID { get; set; }

        public int CustomerID { get; set; }

        public int AddressID { get; set; }

        [ForeignKey("CustomerID")]
        public Customer Customer { get; set; }

        [ForeignKey("AddressID")]
        public Address Address { get; set; }
    }

}