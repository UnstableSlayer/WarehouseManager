using System.ComponentModel.DataAnnotations.Schema;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Currencies", Schema = "crc")]
    public class Currency : BaseEntity
    {
        public string Name { get; set; }
        public string Symbol { get; set; }
        public string Value { get; set; }

        //Other currency to compare with
        public int OtherCurrencyId { get; set; }
    }
}