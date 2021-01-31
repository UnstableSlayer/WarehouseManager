using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Products.Commands
{
    class UpdateWarehouseCommand
    {
        public int Code { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee Manager { get; set; }
    }

    public class UpdateWarehouseCommandValidator : AbstractValidator<Warehouse>
    {
        public UpdateWarehouseCommandValidator()
        {
            RuleFor(warehouse => warehouse.Name).NotNull().NotEmpty().Length(2, 50);
            RuleFor(warehouse => warehouse.Address).NotNull().NotEmpty().Length(2, 50);
            RuleFor(warehouse => warehouse.Manager).NotNull().NotEmpty();
        }
    }
}
