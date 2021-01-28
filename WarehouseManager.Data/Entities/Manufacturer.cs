﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Data.Entities
{
    [Table(name: "Manufacturers", Schema = "mfr")]
    public class Manufacturer : BaseEntity
    {
        public string Name { get; set; }
    }
}
