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
            pm.EmpName = Console.ReadLine();
            Console.WriteLine("Please Enter your Project Manager Name");
            pm.projectManager = Console.ReadLine();
            pm.EmployeeId = $"{pm.EmpName}---{Guid.NewGuid()}";
            Console.WriteLine($"The Employee {pm.EmpName} has joined on {DateTime.Now} with Employee Id {pm.EmployeeId}");

            Company comp = new Company();
            Console.WriteLine("Enter company name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Total Employees");
            int empno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Founder Name");
            string fname = Console.ReadLine();
            string cmpid = $"{name}--{Guid.NewGuid()}";
            Console.WriteLine($"The company {name} with id {cmpid} has been founded by {fname} has total {empno} employees");

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
                pm.EmpName = Console.ReadLine();
                Console.WriteLine("Project Manager Name");
                pm.projectManager = Console.ReadLine();
                pm.EmployeeId = $"{ pm.EmpName }---{ Guid.NewGuid()}";
                pm._employee.Add(pm.EmpName);
                pm._employee.Add(pm.EmployeeId);
                pm._employee.Add(pm.projectManager);
                Console.WriteLine("The following details have been added");



            }


        }
    }
}
