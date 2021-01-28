using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "JobPositions", Schema = "jbp")]
    public class JobPosition : BaseEntity
    {
        public string Name { get; set; }
    }
}
