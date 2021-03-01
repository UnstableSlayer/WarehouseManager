using System;
using System.Collections.Generic;
using System.Text;

namespace WarehouseManager.HttpClientHelper.AccountentTreeServices
{
    public class AccountentTree
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FullCode { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ParentTreeId { get; set; }
        public int? TreeTypeId { get; set; }
    }

    public class CreateAccountentTreeCommand
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string FullCode { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public int? ParentTreeId { get; set; }
        public int? TreeTypeId { get; set; }
    }

    public class UpdateAccountentTreeCommand
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int? ParentTreeId { get; set; }
        public int? TreeTypeId { get; set; }
    }
}
