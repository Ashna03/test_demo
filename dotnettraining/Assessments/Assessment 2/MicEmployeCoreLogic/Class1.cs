using System;
using System.Collections.Generic;

namespace MicEmployeCoreLogic
{
    public class Employee
    {
        public string EmpId { get; set; }
        public string EmpName { get; set; }
        public DateTime DateOfJoining { get; set; }
        public Company Company { get; set; }
        public ProjectManager ProjectManager { get; set; }
        public string ProjectName { get; set; }

        public static List<Employee> emplist = new List<Employee>();
        public void RegisterEmployee(ref Employee emp, string empid, string empname, DateTime datetime, Company comp)
        {
            emp.EmpId = empid;
            emp.EmpName = empname;
            emp.DateOfJoining = datetime;
            emp.Company = Company;
            emplist.Add(emp);
        }

        public bool Add()
        {
            return true;
        }
        public bool Assign(ref Employee emp, string projectname) {
            emp.ProjectName = projectname;
            return true;
        }

        public virtual string Works(string tasks) 
        {
            return $"{EmpName} works on the following task: {tasks}";
        }
    }

    public class Company 
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int TotalEmployees { get; set; }
        public string FounderName { get; set; }
        //public void CreateCompany(int cmpid, string cmpname, int totalemp, string Fname)
        //{
        //    CompanyId = cmpid;
        //    CompanyName = cmpname;
        //    TotalEmployees = totalemp;
        //    FounderName = Fname;

        //}
    }

    public class ProjectManager : Employee
    {
     
        public int TotalTeams { get; set; }

    }
}
