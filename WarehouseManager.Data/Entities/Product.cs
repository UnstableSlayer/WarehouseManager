using System.ComponentModel.DataAnnotations.Schema;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Products", Schema = "prd")]
    public class Product : BaseEntity
    {
        public int Code { get; set; }
        public string Barcode { get; set; }
        public string Boxcode { get; set; }
        public string Name { get; set; }
        public string EN_Name { get; set; }
        public string Unit { get; set; }
        public float Amount { get; set; }
        public ProductCategory Category { get; set; }
        public ProductType Type { get; set; }
        public string Color { get; set; }
        public Country ProductionCountry { get; set; }
        public Manufacturer Manufacturer { get; set; }
        public Brand Brand { get; set; }
        public string ImageURL { get; set; }
        public float ProductionPrice { get; set; }
        public float RetailPrice { get; set; }
    }
}


