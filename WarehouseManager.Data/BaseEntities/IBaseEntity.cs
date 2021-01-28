using System;

namespace WarehouseManager.Data.BaseEntities
{
    public interface IBaseEntity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
