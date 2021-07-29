using log4net;
using log4net.Config;
using MicEmployeCoreLogic;
using System;
using System.IO;
using System.Collections.Generic;
using System.Reflection;

namespace MicEmployeUI
{
    class Program
    {

        private static readonly ILog logger = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new FileInfo("log4net.config"));

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


            try
            {
                logger.Info("Assigning Project to Employee");
                emp.Assign(ref emp, ".NetCore");
            }
            catch (Exception ex)
            {
                logger.Error("An exception has occured");
                logger.Error(ex.Message);
                
            }

            



            logger.Info("Employee Details added successfully");
            Console.WriteLine("The entered employee details are as follows:");
            Console.WriteLine("EmployeeId \t EmployeeName \t DateofJoining \t\t CompanyName \t ProjectName");
            foreach (var empl in Employee.emplist)
            {
                Console.WriteLine($"{empl.EmpId}\t\t{empl.EmpName}\t{empl.DateOfJoining}\t{cmp.CompanyName}\t{empl.ProjectName}");
            }


           

            logger.Info("Assigning Task to a particular Employee");
            Console.WriteLine("Assign task to the employee");
            string task = Console.ReadLine();
            string assignedtask = emp.Works(task);
            Console.WriteLine(assignedtask);
            logger.Info("Task Assigned");


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


            logger.Info("Project Manager and Project assigned to Employee");
            Console.WriteLine("===Printing all the employees with assigned project manager and Project ===");
            Console.WriteLine("EmployeeId\tEmployeeName\tProjectManager\tProjectName");
            foreach (var empl in Employee.emplist)
            {
                Console.WriteLine($"{empl.EmpId}\t{empl.EmpName}\t\t{empl.ProjectManager.EmpName}\t\t{empl.ProjectName}");
            }

            
            
            
           
            
            
        }
    }
}
