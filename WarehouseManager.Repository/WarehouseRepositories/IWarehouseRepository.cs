using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IWarehouseRepository : IRepository<Warehouse>
    {
        Warehouse GetByCode(int codeToFind);
        Warehouse GetByAccount(int accountToFind);
        Warehouse GetByName(string nameToFind);
        Warehouse GetByAddress(string addressToFind);
        Warehouse GetByManager(Employee managerToFind);
    }
}
