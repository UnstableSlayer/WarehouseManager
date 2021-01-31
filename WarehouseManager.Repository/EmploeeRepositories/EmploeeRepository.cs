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
    public class EmployeeRepository : Repository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(WarehouseManagerDBContext empContext) : base(empContext) { }

        public Employee GetFirstOrDefaultByAccountCode(int accountCodeToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.AccountCode == accountCodeToFind);
        }

        public Employee GetFirstOrDefaultByPersonalId(int personalIdToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.PersonalId == personalIdToFind);
        }

        public Employee GetFirstOrDefaultByAddress(string addressToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.Address == addressToFind);
        }

        public Employee GetFirstOrDefaultByEmail(string emailToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.Email == emailToFind);
        }

        public Employee GetFirstOrDefaultByPhoneNumber(string phoneNumberToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.PhoneNumber == phoneNumberToFind);
        }

        public Employee GetFirstOrDefaultByFirstName(string firstNameToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.Firstname == firstNameToFind);
        }

        public Employee GetFirstOrDefaultByLastName(string lastNameToFind)
        {
            return _context.Set<Employee>().FirstOrDefault(x => x.Lastname == lastNameToFind);
        }
    }
}
