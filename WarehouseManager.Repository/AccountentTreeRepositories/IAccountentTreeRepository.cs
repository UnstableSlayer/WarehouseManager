using System.Collections.Generic;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IAccountentTreeRepository : IRepository<AccountentTree>
    {
        AccountentTree GetByCode(int codeToFind);
        AccountentTree GetByFullCode(string fullCodeToFind);
        AccountentTree GetByName(string nameToFind);
    }
}
