﻿using Microsoft.EntityFrameworkCore;
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
    public class AccountentTreeRepository : Repository<AccountentTree>, IAccountentTreeRepository
    {
        public AccountentTreeRepository(WarehouseManagerDBContext actrContext) : base(actrContext) { }

        public AccountentTree GetByCode(int codeToFind)
        {
            return _context.Set<AccountentTree>().FirstOrDefault(x => x.Code == codeToFind);
        }

        public AccountentTree GetByFullCode(string fullCodeToFind)
        {
            return _context.Set<AccountentTree>().FirstOrDefault(x => x.FullCode == fullCodeToFind);
        }

        public AccountentTree GetByName(string nameToFind)
        {
            return _context.Set<AccountentTree>().FirstOrDefault(x => x.Name == nameToFind);
        }
    }
}
