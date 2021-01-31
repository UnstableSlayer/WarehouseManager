using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository;
using WarehouseManager.Service.Employees.Commands;
using FluentValidation;
using WarehouseManager.Common.Exceptions;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Service.Employees
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _repository;
        public EmployeeService(IRepository<Employee> employeerepository)
        {
            _repository = employeerepository;
        }

        public void CreateEmployee(CreateEmployeeCommand command)
        {
            CreateEmployeeCommandValidator validator = new CreateEmployeeCommandValidator();
            var results = validator.Validate(command);
            if(!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }
            _repository.Insert(new Employee() {
                AccountCode = command.AccountCode,
                PersonalId = command.PersonalId,
                Firstname = command.Firstname,
                Lastname = command.Lastname,
                Gender = command.Gender,
                Nationality = command.Nationality,
                Citizenship = command.Citizenship,
                Address = command.Address,
                PhoneNumber = command.PhoneNumber,
                Email = command.Email,
                JobPosition = command.JobPosition,
                BirthDay = command.BirthDay
            });
        }

        public void DeleteEmployeeByEmail(DeleteEmployeeByEmailCommand command)
        {
            DeleteEmployeeByEmailCommandValidator validator = new DeleteEmployeeByEmailCommandValidator();
            var results = validator.Validate(command);
            if (!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError
                {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }
            var employees = _repository.GetAll();
            var employeeToDelete = employees.Single(x => x.Email == command.Email);
            _repository.Delete(employeeToDelete.Id);
        }

        public void UpdateEmployee(Employee command)
        {
            UpdateEmployeeCommandValidator validator = new UpdateEmployeeCommandValidator();
            var results = validator.Validate(command);
            if (!results.IsValid)
            {
                throw new CommandValidationException(results.Errors.Select(x => new CommandValidationError
                {
                    ErrorCode = x.ErrorCode,
                    ErrorMessage = x.ErrorMessage,
                    PropertyName = x.PropertyName
                }));
            }
            _repository.Update(new Employee()
            {
                AccountCode = command.AccountCode,
                PersonalId = command.PersonalId,
                Firstname = command.Firstname,
                Lastname = command.Lastname,
                Gender = command.Gender,
                Nationality = command.Nationality,
                Citizenship = command.Citizenship,
                Address = command.Address,
                PhoneNumber = command.PhoneNumber,
                Email = command.Email,
                JobPosition = command.JobPosition,
                BirthDay = command.BirthDay
            });
        }
    }
}
