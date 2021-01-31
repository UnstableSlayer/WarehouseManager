using System.Collections.Generic;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface ICurrencyRepository : IRepository<Currency>
    {
        Currency GetFirstOrDefaultByName(string nameToFind);
        Currency GetFirstOrDefaultBySymbol(string symbolToFind);
        Currency GetFirstOrDefaultByCode(string codeToFind);
    }
}
