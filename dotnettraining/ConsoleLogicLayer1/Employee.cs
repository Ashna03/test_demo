using System;
using System.Collections.Generic;
using System.Text;

namespace CoreLogicLayer1
{
    public class Employee
    {
        public string EmpName { get; set; }
        public int Salary { get; set; }
        public Guid EmpId { get; set; }

        public void EmpDetails(string name) 
        {
            EmpName = name;
            EmpId = Guid.NewGuid();
            Console.WriteLine($"The Employee Id is {EmpId}");
        }

        public void EmpSalary() 
        {
            Console.WriteLine("Enter the Employee Salary");
            int sal = Convert.ToInt32(Console.ReadLine());
            Salary = sal;
        }
    }
}
