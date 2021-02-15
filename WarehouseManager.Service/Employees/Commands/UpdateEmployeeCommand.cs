using System;
using FluentValidation;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Employees.Commands
{
    public class UpdateEmployeeCommand
    {
        public int Id { get; set; }
        public int AccountCode { get; set; }
        public int PersonalId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Gender { get; set; }
        public Country Nationality { get; set; }
        public string Citizenship { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public JobPosition JobPosition { get; set; }
        public DateTime BirthDay { get; set; }
    }

    public class UpdateEmployeeCommandValidator : AbstractValidator<UpdateEmployeeCommand>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(employee => employee.PersonalId).NotNull().NotEmpty().GreaterThan(0);
            RuleFor(employee => employee.Firstname).NotNull().NotEmpty().MaximumLength(50).MinimumLength(2);
            RuleFor(employee => employee.Lastname).NotNull().NotEmpty().Length(2, 50);
            RuleFor(employee => employee.PhoneNumber).Length(9, 13);
            RuleFor(employee => employee.Email).EmailAddress();
        }
    }
}
