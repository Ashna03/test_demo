using Employee_BAL.Service;
using Employee_DAL.Interface;
using Employee_DAL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeAssessment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeDetailsController : ControllerBase
    {
        private readonly EmployeeService _employeeservice;
        private readonly IRepository<Employee> _employeerepo;

        public EmployeeDetailsController(EmployeeService employeeservice, IRepository<Employee> employeerepo)
        {
            _employeeservice = employeeservice;
            _employeerepo = employeerepo;
        }

        [HttpGet("/getemployee")]

        public Object GetEmployeeById(int id)
        {
            var result = _employeeservice.GetEmployeeById(id);
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;
        }

        [HttpPost("/getallemployees")]
        public Object GetAllEmployees(string company)
        {
            var result = _employeeservice.GetAllEmployee(company);
            var jsonResult = JsonConvert.SerializeObject(result);
            return jsonResult;

        }

        [HttpPost("/addemployee")]

        public async Task<Employee> AddEmployee([FromBody] Employee emp)
        {
            var addemployee = await _employeeservice.AddNewEmployee(emp);
            return addemployee;
        }

        [HttpPut("/updateemployee")]

        public bool UpdateEmployee(Employee emp)
        {
            try
            {
                _employeeservice.UpdateEmployee(emp);
                return true;
            }
            catch 
            {

                return false;
            }
        
        }
    }
}
