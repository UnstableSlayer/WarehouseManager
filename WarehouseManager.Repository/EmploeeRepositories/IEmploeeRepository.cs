using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetFirstOrDefaultByAccountCode(int accountCodeToFind);
        Employee GetFirstOrDefaultByPersonalId(int personalIdToFind);
        Employee GetFirstOrDefaultByFirstName(string firstNameToFind);
        Employee GetFirstOrDefaultByLastName(string lastNameToFind);
        Employee GetFirstOrDefaultByEmail(string emailToFind);
        Employee GetFirstOrDefaultByAddress(string addressToFind);
        Employee GetFirstOrDefaultByPhoneNumber(string phoneNumberToFind);
    }
}
