using Employee_DAL.Data;
using Employee_DAL.Interface;
using Employee_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_DAL.Repository
{
    public class RepositoryEmployee : IRepository<Employee>
    {
        private EmployeeDBContext _dbcontext;
        public RepositoryEmployee(EmployeeDBContext dbcontextobj)
        {
            _dbcontext = dbcontextobj;
        }
        public async Task<Employee> Add(Employee obj)
        {
            
            var returnedemployee = await _dbcontext.Employees.AddAsync(obj);
            _dbcontext.SaveChanges();
            return returnedemployee.Entity;
        }

        public IEnumerable<Employee> DisplayAll(string company)
        {
            try
            {
                return _dbcontext.Employees.Where(x => x.Company == company).ToList();
            }
            catch
            {

                throw;
            }
        }

        public Employee DisplayById(int id)
        {
            try
            {
                return _dbcontext.Employees.Where(x => x.EmployeeId.Equals(id)).FirstOrDefault();
            }
            catch
            {

                throw;
            }

        }

        public void Update(Employee emp)
        {
            _dbcontext.Update(emp);
            _dbcontext.SaveChanges();
        }

    }
}
