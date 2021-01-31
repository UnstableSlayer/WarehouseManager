using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.WareHouses;
using WarehouseManager.Service.WareHouses.Commands;

namespace WarehouseManager.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WarehouseController : ControllerBase
    {
        private readonly IRepository<Warehouse> _repository;
        private readonly IWarehouseRepository _warehouseRepository;
        private readonly WarehouseService _warehouseService;
        public WarehouseController(IRepository<Warehouse> repository, IWarehouseRepository warehouseRepository, WarehouseService warehouseService)
        {
            _repository = repository;
            _warehouseRepository = warehouseRepository;
            _warehouseService = warehouseService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Warehouse>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Warehouse> GetById(int Id)
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
            var employeeModelFromRepo = _warehouseRepository.GetByAddress(Address);
            if (employeeModelFromRepo == null)
            {
                return NotFound();
            }


            return Ok(employeeModelFromRepo);
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee(CreateWareHouseCommand command)
        {
            _warehouseService.CreateWareHouse(command);
            return Ok(command);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteEmployee(int Id)
        {
            var warehouseModelFromRepo = _repository.GetById(Id);
            if (warehouseModelFromRepo == null)
            {
                return NotFound();
            }
            _repository.Delete(Id);

            return Ok();
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateEmployee(int Id, Warehouse command)
        {
            if(Id != command.Id)
            {
                return BadRequest();
            }
            var warehouseModelFromRepo = _repository.GetById(Id);
            if(warehouseModelFromRepo == null)
            {
                return NotFound();
            }

            _warehouseService.UpdateWarehouse(command);

            return NoContent();
        }
    }
}
