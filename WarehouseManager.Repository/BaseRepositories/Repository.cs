using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseManager.Data;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected readonly WarehouseManagerDBContext _context;
        private DbSet<T> entities;

        public Repository(WarehouseManagerDBContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }

        public void Delete(int idToDelete)
        {
            if (idToDelete <= 0) throw new ArgumentOutOfRangeException("Id is negative or zero");

            T entitytodelete = GetById(idToDelete);
            entities.Remove(entitytodelete);
            _context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return entities.AsEnumerable();
        }

        public T GetById(int idToFind)
        {
            if (idToFind <= 0) throw new ArgumentOutOfRangeException("Id is negative or zero");

            return entities.SingleOrDefault(x => x.Id == idToFind);
        }

        public void Insert(T toInsert)
        {
            if (toInsert == null) throw new ArgumentNullException("Entity is null");

            entities.Add(toInsert);
            _context.SaveChanges();
        }

        public void Update(T toUpdate)
        {
            if (toUpdate == null) throw new ArgumentNullException("Entity is null");

            T tmp = GetById(toUpdate.Id);

            _context.Update(toUpdate);
            //_context.Entry(tmp).CurrentValues.SetValues(toUpdate);
            //_context.SaveChanges();
        }
        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }
    }
}
