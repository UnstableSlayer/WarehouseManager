﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Service.Employees.Commands
{
    public class UpdateEmployeeCommand
    {
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

    public class UpdateEmployeeCommandValidator : AbstractValidator<Employee>
    {
        public UpdateEmployeeCommandValidator()
        {
            RuleFor(employee => employee.PhoneNumber).Length(9, 13);
            RuleFor(employee => employee.Email).EmailAddress();
            RuleFor(employee => employee.Firstname).NotNull().NotEmpty().MaximumLength(50).MinimumLength(2);
            RuleFor(employee => employee.Lastname).NotNull().NotEmpty().Length(2, 50);
            RuleFor(employee => employee.PersonalId).NotNull().NotEmpty().GreaterThan(0);
        }
    }
}