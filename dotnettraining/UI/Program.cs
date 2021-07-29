using CoreLogicLayer1;
using System;

namespace UI
{
    class Program
    {
        static void Main(string[] args)
        {
            IAmPublic obj = new IAmPublic();
            obj.IAPuProp = 1000;
            Console.WriteLine($"The value of {nameof(obj.IAPuProp)} : {obj.IAPuProp}");
            
            //------For employee.cs-------
            Employee emp = new Employee();
            emp.EmpDetails("Ramesh");
            emp.EmpSalary();
            Console.WriteLine($"The salary of {emp.EmpName} is {emp.Salary}");


        }
    }
}
