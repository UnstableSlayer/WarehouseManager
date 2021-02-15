using System.Collections.Generic;
using WarehouseManager.Data.Entities;
using WarehouseManager.Repository.BaseRepositories;

namespace WarehouseManager.Repository.BaseRepositories
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Employee GetByAccountCode(int accountCodeToFind);
        Employee GetByPersonalId(int personalIdToFind);
        Employee GetByFirstName(string firstNameToFind);
        Employee GetByLastName(string lastNameToFind);
        Employee GetByEmail(string emailToFind);
        Employee GetByAddress(string addressToFind);
        Employee GetByPhoneNumber(string phoneNumberToFind);
    }
}
