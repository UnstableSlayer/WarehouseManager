using System;
using System.ComponentModel.DataAnnotations.Schema;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Employees", Schema = "emp")]
    public class Employee : BaseEntity
    {
        public int AccountCode { get; set; }
        public int PersonalId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public Country Nationality { get; set; }
        public string Citizenship { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public JobPosition JobPosition { get; set; }
        public DateTime BirthDay { get; set; }
    }
}

