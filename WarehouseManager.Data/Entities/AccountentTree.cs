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
        public int Code { get; set; }
        public string FullCode { get; set; }
        public string Name { get; set; }
        public int? ParentTreeId { get; set; }
        public AccountentTree? ParentTree { get; set; }
        public int? TreeTypeId { get; set; }
        public AccountentTreeType TreeType { get; set; }
        public virtual IEnumerable<AccountentTree> Children { get; set; }
    }
}
