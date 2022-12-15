using Domain;
using Domain.Entities;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implimentation
{
    public class EmployeeRepository : RepositoryBase<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DataBaseContext dataBase) : base(dataBase)
        {
        }

        public void AddEmployee(int DepId, Employee employee)
        {
            employee.DepId = DepId;
            Add(employee);
        }

        public void DeleteEmployee(Employee employee)
        {
            Remove(employee);
        }

        public IEnumerable<Employee> GetAllEmployees(int Depid)
        {
            return Find(x => x.DepId == Depid).ToList();
        }

        public Employee GetEmployee(int DepId, int id)
        {
            return Find(x => x.DepId == DepId && x.Id == id).FirstOrDefault();
        }
    }
}