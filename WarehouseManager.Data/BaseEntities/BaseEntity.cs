using System;

namespace WarehouseManager.Data.BaseEntities
{
    public class BaseEntity : IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; } = DateTime.Now;
    }
}
