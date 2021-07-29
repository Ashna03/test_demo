using System;
using System.Collections;
using System.Collections.Generic;

namespace CompanyLogicLayer
{
    public abstract class Employee
    {
        public abstract bool Add();
        public abstract bool Remove();
        public abstract bool Assign(string ProjectName);
        public virtual string Works(string[] Tasks) 
        {
            return $"{EmpName} is working on {Tasks}";      
        }
        //protected List<Employee> GetTeamMembers();

        public string EmployeeId { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfJoining;
        public string projectManager { get; set; }
        public Company Company { get; set; }
        public ArrayList _employee;
        
        

        
    }

    public class Company
    {
        public string CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int TotalEmployees { get; set; }
        public string FounderName { get; set; }

    }

    public class ProjectManager : Employee
    {
        //public ProjectManager(string name, string EmpId, string ProjectManager)
        //{
        //    EmpName = name;
        //    EmployeeId = EmpId;
        //    projectManager = ProjectManager;
        //}
        public override bool Add()
        {
            Console.WriteLine("Do you want to Add Employees?");
            Console.WriteLine("Please enter your choice as Y/N");
            string emp_add = Console.ReadLine();
            if (emp_add == "Y") 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Remove()
        {
            Console.WriteLine("Do you want to Remove Employees?");
            Console.WriteLine("Please enter your choice as Y/N");
            string emp_rem = Console.ReadLine();
            if (emp_rem == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override bool Assign(string ProjectName)
        {
            Console.WriteLine("Do you want to Assign Any Employees to Project {ProjectName}?");
            Console.WriteLine("Please enter your choice as Y/N");
            string emp_assign = Console.ReadLine();
            if (emp_assign == "Y")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }


    }

