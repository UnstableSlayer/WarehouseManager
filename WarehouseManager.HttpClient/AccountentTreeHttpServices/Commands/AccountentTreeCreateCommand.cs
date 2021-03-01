using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.HttpClientHelper.AccountentTreeHttpServices.Commands
{
    class AccountentTreeCreateCommand
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int? ParentTreeId { get; set; }
        public int? TreeTypeId { get; set; }
    }
}
