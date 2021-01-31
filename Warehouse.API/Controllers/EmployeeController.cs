using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.Employees;
using WarehouseManager.Service.Employees.Commands;

namespace WarehouseManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> _repository;
        private readonly IEmployeeRepository _employeeRepository;
        private readonly EmployeeService _employeeService;
        public EmployeeController(IRepository<Employee> repository, IEmployeeRepository employeeRepository, EmployeeService employeeService)
        {
            _repository = repository;
            _employeeRepository = employeeRepository;
            _employeeService = employeeService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Employee> GetById(int Id)
        {
            var employeeModelFromRepo = _repository.GetById(Id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            return Ok(employeeModelFromRepo);
        }

        [HttpGet("{Address}")]
        public ActionResult<Employee> GetByAddress(string Address)
        {
            var employeeModelFromRepo = _employeeRepository.GetFirstOrDefaultByAddress(Address);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }


            return Ok(employeeModelFromRepo);
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee(CreateEmployeeCommand command)
        {
            _employeeService.CreateEmployee(command);
            return Ok(command);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteEmployee(int Id)
        {
            var employeeModelFromRepo = _repository.GetById(Id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.Delete(Id);

            return Ok();
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateEmployee(int Id, Employee command)
        {
            if(Id != command.Id)
            {
                return BadRequest();
            }
            var employeeModelFromRepo = _repository.GetById(Id);
            if(employeeModelFromRepo == null)
            {
                return NotFound();
            }

            _employeeService.UpdateEmployee(command);

            return NoContent();
        }
    }
}
