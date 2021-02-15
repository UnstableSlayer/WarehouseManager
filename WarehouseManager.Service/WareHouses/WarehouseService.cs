using System.Linq;
using WarehouseManager.Common.Exceptions;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;
using WarehouseManager.Service.WareHouses.Commands;
using WarehouseManager.Service.Products.Commands;

namespace WarehouseManager.Service.WareHouses
{
    public class WarehouseService
    {
        private readonly IRepository<Warehouse> _repository;
        public WarehouseService(IRepository<Warehouse> warehouserepository)
        {
            _repository = warehouserepository;
        }

        public void CreateWareHouse(CreateWareHouseCommand command)
        {
            CreateWareHouseCommandValidator validator = new CreateWareHouseCommandValidator();
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
            _repository.Insert(new Warehouse
            {
                Code = command.Code,
                Account = command.Account,
                Name = command.Name,
                Address = command.Address,
                Manager = command.Employee
            });
        }

        public void UpdateWarehouse(Warehouse command)
        {
            UpdateWarehouseCommandValidator validator = new UpdateWarehouseCommandValidator();
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
            _repository.Update(new Warehouse()
            {
                Code = command.Code,
                Account = command.Account,
                Name = command.Name,
                Address = command.Address,
                Manager = command.Manager,
            });
        }
    }
}
