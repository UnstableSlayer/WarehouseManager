using FluentValidation;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.WareHouses.Commands
{
    public class CreateWareHouseCommand
    {
        public int Code { get; set; }
        public int Account { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }

    public class CreateWareHouseCommandValidator : AbstractValidator<CreateWareHouseCommand>
    {
        public CreateWareHouseCommandValidator()
        {
            RuleFor(warehouse => warehouse.Code).GreaterThan(0);
            RuleFor(warehouse => warehouse.Account).GreaterThan(0);
            RuleFor(warehouse => warehouse.Name).NotNull().NotEmpty().Length(0, 50);
            RuleFor(warehouse => warehouse.Address).NotNull().NotEmpty();
            RuleFor(warehouse => warehouse.Employee.Id).GreaterThanOrEqualTo(0);
        }
    }
}
