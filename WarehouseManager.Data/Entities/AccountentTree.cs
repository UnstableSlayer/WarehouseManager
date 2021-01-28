using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "AccountentTree", Schema = "actr")]
    public class AccountentTree : BaseEntity
    {
        public string Code { get; private set; }
        public string FullCode { get; private set; }
        public string Name { get; private set; }
        public AccountentTree ParentTree { get; set; }
        public AccountentTreeType TreeType { get; private set; }
    }
}
