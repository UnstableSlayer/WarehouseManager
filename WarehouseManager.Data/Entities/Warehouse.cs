using System.ComponentModel.DataAnnotations.Schema;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Warehouses", Schema = "wrh")]
    public class Warehouse : BaseEntity
    {
        public int Code { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee Manager { get; set; }
    }
}
