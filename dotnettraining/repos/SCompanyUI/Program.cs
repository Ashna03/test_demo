using CompanyLogicLayer;
using System;
using System.Collections;
using System.Collections.Generic;

namespace SCompanyUI
{
    class Program
    {
        ArrayList _employee = new ArrayList();
        static void Main(string[] args)
        {
            ProjectManager pm = new ProjectManager();
            Console.WriteLine("Welcome to Sapient MIS");
            Console.WriteLine("Please Enter your name");
            string empname = Console.ReadLine();
            Console.WriteLine("Please Enter your Project Manager Name");
            string projectmanager = Console.ReadLine();
            string empid = $"{pm.EmpName}--{Guid.NewGuid()}";
            DateTime joiningdate = DateTime.Now;
            pm.CreateEmployee(empid, empname,joiningdate, projectmanager);
            Console.WriteLine($"The Employee {pm.EmpName} has joined on {pm.DateOfJoining} with Employee Id {pm.EmployeeId}");
             

            Console.WriteLine("Enter Company Details:");
            Company comp = new Company();
            Console.WriteLine("Enter company name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Total Employees");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Founder Name");
            string fname = Console.ReadLine();
            comp.CompanyId= $"{name}-{Guid.NewGuid()}";
            comp.CompanyDetails(name,empno,fname);
            Console.WriteLine($"The company {comp.CompanyName} with id {comp.CompanyId} has been founded by {comp.FounderName} has total {comp.TotalEmployees} employees");

            Console.WriteLine("The Employee Details are as Follows");
            ArrayList _employee = new ArrayList();
            _employee.Add(pm.EmpName);
            _employee.Add(pm.EmployeeId);
            _employee.Add(pm.projectManager);

            foreach (var employeedetails in _employee)
            {
                Console.WriteLine(employeedetails);            
            }

            AddEmployee(pm);

           


        }

        public static void AddEmployee(ProjectManager pm)
        {
            bool ToAdd = pm.Add();
            if (ToAdd)
            {
                Console.WriteLine("Enter the details of Employee");
                Console.WriteLine("Employee Name");
                string empname = Console.ReadLine();
                Console.WriteLine("Project Manager Name");
                string projectmanager = Console.ReadLine();
                string empid = $"{empname}---{ Guid.NewGuid()}";
                ArrayList _employee = new ArrayList();
                pm.CreateEmployee(empid, empname, DateTime.Now, projectmanager);
                _employee.Add(empname);
                _employee.Add(empid);
                _employee.Add(projectmanager);
                Console.WriteLine("The following details have been added");



            }


        }
    }
}
