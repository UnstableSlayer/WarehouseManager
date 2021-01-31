using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.WareHouses.Commands
{
    public class CreateWareHouseCommand
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public Employee Employee { get; set; }
    }

    public class CreateWareHouseCommandValidator : AbstractValidator<CreateWareHouseCommand>
    {
        public CreateWareHouseCommandValidator()
        {
            RuleFor(warehouse => warehouse.Name).NotNull().NotEmpty().Length(0, 50);
            RuleFor(warehouse => warehouse.Address).NotNull().NotEmpty();
            RuleFor(warehouse => warehouse.Employee.Id).GreaterThanOrEqualTo(0);
            //RuleFor(warehouse => warehouse.Employee.Age).NotNull().GreaterThan(18);
            //RuleFor(warehouse => warehouse.Employee.PhoneNumber).Length(9, 13);
            //RuleFor(warehouse => warehouse.Employee.Email).EmailAddress();
            //RuleFor(warehouse => warehouse.Employee.FirstName).NotNull().NotEmpty().MaximumLength(50).MinimumLength(2);
            //RuleFor(warehouse => warehouse.Employee.LastName).NotNull().NotEmpty().Length(2, 50);
        }
    }
}
