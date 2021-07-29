using MicEmployeCoreLogic;
using System;
using System.Collections.Generic;

namespace MicEmployeUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emplist = new List<Employee>();
            Company cmp = new Company();
            cmp.CompanyName = "Sapients";
            Console.WriteLine("------ Welcome to Sapient MIS -----");
            Console.WriteLine("Add Employee Details");
            int uniqueid = Guid.NewGuid().GetHashCode();
            Console.WriteLine("Enter Employee Name");
            string empname = Console.ReadLine();
            string empid = $"{empname.Substring(0, 3)}-{uniqueid}";
            var Jdate = DateTime.Now;
            Employee emp = new Employee();
            emp.RegisterEmployee(ref emp,empid,empname,Jdate,cmp);
            emp.Assign(ref emp, ".NetCore");
            Console.WriteLine("The entered employee details are as follows:");
            Console.WriteLine("EmployeeId \t EmployeeName \t DateofJoining \t\t CompanyName \t ProjectName");
            foreach (var empl in Employee.emplist)
            {
                Console.WriteLine($"{empl.EmpId}\t\t{empl.EmpName}\t{empl.DateOfJoining}\t{cmp.CompanyName}\t{empl.ProjectName}");
            }


            //Console.WriteLine("Do u want to add more employees ");
            //string choice = Console.ReadLine().ToLower();
            //if (choice == "yes")
            //    goto start;



            Console.WriteLine("Assign task to the employee");
            string task = Console.ReadLine();
            string assignedtask = emp.Works(task);
            Console.WriteLine(assignedtask);


            Console.WriteLine("===Assigning Project Manager=====");
            Console.WriteLine("Enter name of Project Manager");
            string pname = Console.ReadLine();
            Console.WriteLine("Enter teams");
            int teams = int.Parse(Console.ReadLine());
            //Employee e = Employee.emplist.Find((p) => p.EmpName == pname);
            ProjectManager pm = new ProjectManager();
            pm.EmpName = pname;
            pm.TotalTeams = teams;
            pm.Company = cmp;
            foreach (var empl in Employee.emplist)
            {
                empl.ProjectManager = pm;
            }


            Console.WriteLine("===Printing all the employees with assigned project manager and Project ===");
            Console.WriteLine("EmployeeId\tEmployeeName\tProjectManager\tProjectName");
            foreach (var empl in Employee.emplist)
            {
                Console.WriteLine($"{empl.EmpId}\t{empl.EmpName}\t\t{empl.ProjectManager.EmpName}\t\t{empl.ProjectName}");
            }

            
            
            
           
            
            
        }
    }
}
