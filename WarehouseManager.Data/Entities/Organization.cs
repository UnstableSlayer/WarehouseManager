using System.ComponentModel.DataAnnotations.Schema;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Organizations", Schema = "org")]
    public class Organization : BaseEntity
    {
        public string Code { get; set; }
        public string AuthenticationCode { get; set; }
        public string Name { get; set; }
        public string EN_Name { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string PostalCode { get; set; }
        public string Address { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string WebsiteURL { get; set; }
        public OrganizationType OrgType { get; set; } //მომწოდებელი; კლიენტი; შეჩერებული
    }
}


