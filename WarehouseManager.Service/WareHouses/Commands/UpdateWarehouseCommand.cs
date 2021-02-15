using FluentValidation;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Products.Commands
{
    class UpdateAccountentTreeCommand
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
            RuleFor(warehouse => warehouse.Code).GreaterThan(0);
            RuleFor(warehouse => warehouse.Account).GreaterThan(0);
            RuleFor(warehouse => warehouse.Name).NotNull().NotEmpty().Length(2, 50);
            RuleFor(warehouse => warehouse.Address).NotNull().NotEmpty().Length(2, 50);
            RuleFor(warehouse => warehouse.Manager).NotNull().NotEmpty();
        }
    }
}
