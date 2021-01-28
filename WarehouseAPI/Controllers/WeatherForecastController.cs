using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;


namespace WareHouseApp.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly IRepository<Employee> _employeeRepository;
        public EmployeeController(IRepository<Employee> repository)
        {
            _employeeRepository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAll()
        {
            return Ok(_employeeRepository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Employee> GetById(int Id)
        {
            var employeeModelFromRepo = _employeeRepository.GetById(Id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            return Ok(employeeModelFromRepo);
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee(Employee employee)
        {
            _employeeRepository.Insert(employee);
            return Ok(employee);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteEmployee(int Id)
        {
            var employeeModelFromRepo = _employeeRepository.GetById(Id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }
            _employeeRepository.Delete(Id);

            return NoContent();
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateEmployee(int Id, Employee employee)
        {
            if (Id != employee.Id)
            {
                return BadRequest();
            }
            var employeeModelFromRepo = _employeeRepository.GetById(Id);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }

            _employeeRepository.Update(employee);

            return NoContent();
        }
    }
}
