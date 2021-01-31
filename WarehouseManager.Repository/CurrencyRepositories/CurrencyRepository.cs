using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data;
using WarehouseManager.Data.BaseEntities;
using WarehouseManager.Data.Entities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public class CurrencyRepository : Repository<Currency>, ICurrencyRepository
    {
        public CurrencyRepository(WarehouseManagerDBContext curContext) : base(curContext) { }

        public Currency GetFirstOrDefaultByCode(string codeToFind)
        {
            return _context.Set<Currency>().FirstOrDefault(x => x.Code == codeToFind);
        }

        public Currency GetFirstOrDefaultByName(string nameToFind)
        {
            return _context.Set<Currency>().FirstOrDefault(x => x.Name == nameToFind);
        }

        public Currency GetFirstOrDefaultBySymbol(string symbolToFind)
        {
            return _context.Set<Currency>().FirstOrDefault(x => x.Symbol == symbolToFind);
        }
    }
}
