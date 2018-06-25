using MvcAreaHosting.BaseModels.Content;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcAreaHosting.BaseModels.Addressing
{
    public enum AddressType
    {
        Home,
        Work,
        CO,
        Billing,
        Delivery,
        Company
    }

    [Table("Address", Schema = "Adressing")]
    public class Address
    {
        [Key]
        public int AddressID { get; set; }

        public AddressType AddressType { get; set; }

        public string Street { get; set; }

        public string ATT { get; set; }

        public string ZipCode { get; set; }

        public string City { get; set; }

        public int CountryID { get; set; }

        [ForeignKey("CountryID")]
        public Country Country { get; set; }
    }

    [Table("Country", Schema = "Adressing")]
    public class Country
    {
        [Key]
        public int CountryID { get; set; }

        public string CountryName { get; set; }

        public string CountryCode { get; set; }

        public string CultureCode { get; set; }

        public int TelephoneCode { get; set; }

        [ForeignKey("CultureCode")]
        public Culture DefaultLocale { get; set; }
    }
}