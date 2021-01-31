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
    public class WarehouseRepository : Repository<Warehouse>, IWarehouseRepository
    {
        public WarehouseRepository(WarehouseManagerDBContext wrhContext) : base(wrhContext) { }

        public Warehouse GetByAccount(int accountToFind)
        {
            return _context.Set<Warehouse>().FirstOrDefault(x => x.Account == accountToFind);
        }

        public Warehouse GetByAddress(string addressToFind)
        {
            return _context.Set<Warehouse>().FirstOrDefault(x => x.Address == addressToFind);
        }

        public Warehouse GetByCode(int codeToFind)
        {
            return _context.Set<Warehouse>().FirstOrDefault(x => x.Code == codeToFind);
        }

        public Warehouse GetByManager(Employee managerToFind)
        {
            return _context.Set<Warehouse>().FirstOrDefault(x => x.Manager == managerToFind);
        }

        public Warehouse GetByName(string nameToFind)
        {
            return _context.Set<Warehouse>().FirstOrDefault(x => x.Name == nameToFind);
        }
    }
}
