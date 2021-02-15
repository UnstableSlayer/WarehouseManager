using System.Collections.Generic;
using WarehouseManager.Data.BaseEntities;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int? idToFind);
        void Insert(T toInsert);
        void Delete(int idToDelete);
        void Update(T toUpdate);
        bool SaveChanges();
    }
}
