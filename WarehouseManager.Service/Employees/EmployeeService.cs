using System.Linq;
using WarehouseManager.Data.Entities;
using WarehouseManager.Service.Employees.Commands;
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

        public void UpdateEmployee(UpdateEmployeeCommand command)
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
