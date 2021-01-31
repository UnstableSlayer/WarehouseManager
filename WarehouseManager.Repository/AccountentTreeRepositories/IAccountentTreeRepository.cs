using System.Collections.Generic;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IAccountentTreeRepository : IRepository<AccountentTree>
    {
        AccountentTree GetFirstOrDefaultByCode(int codeToFind);
        AccountentTree GetFirstOrDefaultByFullCode(int fullCodeToFind);
        AccountentTree GetFirstOrDefaultByName(string nameToFind);
    }
}
