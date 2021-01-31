using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarehouseManager.Service.Employees.Commands
{
    public class DeleteEmployeeByEmailCommand
    {
        public string Email { get; set; }
    }

    public class DeleteEmployeeByEmailCommandValidator : AbstractValidator<DeleteEmployeeByEmailCommand>
    {
        public DeleteEmployeeByEmailCommandValidator()
        {
            RuleFor(employee => employee.Email).EmailAddress(); 
        }
    }
}
