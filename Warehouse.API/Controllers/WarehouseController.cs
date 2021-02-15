using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.AccountentTrees;
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

        [HttpPost]
        public ActionResult<Warehouse> CreateWarehouse(CreateWareHouseCommand command)
        {
            _warehouseService.CreateWareHouse(command);
            return Ok(command);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Warehouse>> GetAll()
        {
            return Ok(_repository.GetAll());
        }

        [HttpGet("{Id:int}")]
        public ActionResult<Warehouse> GetById(int Id)
        {
            var warehouseToFind = _repository.GetById(Id);
            if (warehouseToFind == null)
            {
                return NotFound();
            }

            return Ok(warehouseToFind);
        }

        [HttpGet("{Address}")]
        public ActionResult<Warehouse> GetByAddress(string Address)
        {
            var warehouseToFind = _warehouseRepository.GetByAddress(Address);
            if (warehouseToFind == null)
            {
                return NotFound();
            }


            return Ok(warehouseToFind);
        }

        [HttpGet("{Code}")]
        public ActionResult<Warehouse> GetByCode(int Code)
        {
            var warehouseToFind = _warehouseRepository.GetByCode(Code);
            if (warehouseToFind == null)
            {
                return NotFound();
            }


            return Ok(warehouseToFind);
        }

        [HttpPut("{Id}")]
        public ActionResult UpdateWarehouseById(int Id, Warehouse command)
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

            return Ok();
        }

        [HttpPut("{Code}")]
        public ActionResult UpdateWarehouseByCode(int Code, Warehouse command)
        {
            var warehouseModelFromRepo = _warehouseRepository.GetByCode(Code);
            if (warehouseModelFromRepo == null)
            {
                return NotFound();
            }

            _warehouseService.UpdateWarehouse(command);

            return Ok();
        }


        [HttpDelete("{Id}")]
        public ActionResult DeleteWarehouseById(int Id)
        {
            var warehouseToDelete = _repository.GetById(Id);
            if (warehouseToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(warehouseToDelete.Id);

            return Ok();
        }

        [HttpDelete("{Code}")]
        public ActionResult DeleteWarehouseByCode(int Code)
        {
            var warehouseToDelete = _warehouseRepository.GetByCode(Code);
            if (warehouseToDelete == null)
            {
                return NotFound();
            }
            _repository.Delete(warehouseToDelete.Id);

            return Ok();
        }
    }
}
