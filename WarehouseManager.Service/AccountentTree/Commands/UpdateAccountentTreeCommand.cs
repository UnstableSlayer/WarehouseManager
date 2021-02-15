using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.AccountentTrees.Commands
{
    public class UpdateAccountentTreeCommand
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int? ParentTreeId { get; set; }
        public int? TreeTypeId { get; set; }
    }

    public class UpdateAccountentTreeCommandValidator : AbstractValidator<UpdateAccountentTreeCommand>
    {
        public UpdateAccountentTreeCommandValidator()
        {
            RuleFor(warehouse => warehouse.Id).GreaterThan(0);
            RuleFor(warehouse => warehouse.Code).GreaterThan(0);
            RuleFor(warehouse => warehouse.Name).NotNull().NotEmpty().Length(0, 50);
        }
    }
}
