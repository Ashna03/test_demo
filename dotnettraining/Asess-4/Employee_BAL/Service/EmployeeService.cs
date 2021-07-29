using Employee_DAL.Interface;
using Employee_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_BAL.Service
{
    public class EmployeeService
    {
        private readonly IRepository<Employee> _employee;
        public EmployeeService(IRepository<Employee> employee)
        {
            _employee = employee;
        }

        public Employee GetEmployeeById(int id)
        {
            return _employee.DisplayById(id);
        }

        public IEnumerable<Employee> GetAllEmployee(string company)
        {
            return _employee.DisplayAll(company);
        }

        public void UpdateEmployee(Employee emp)
        {
            _employee.Update(emp);
        }

        public Task<Employee> AddNewEmployee(Employee emp)
        {
            return _employee.Add(emp);
        }

    }
}
