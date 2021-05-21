using System;
using System.Collections.Generic;
namespace Generics_CS.Gen2
{
    

    
    class Program
    {

        static void Main(string[] args)
        {

            EmployeeManagement<Employee> employeeManagement = new EmployeeManagement<Employee>();
            employeeManagement.Employ("ab");
            employeeManagement.Employ("ad");
            employeeManagement.Employ("cd");
            employeeManagement.AddPointsTo(0);
            employeeManagement.Display(employeeManagement.SortBy(SortType.ID));
            employeeManagement.Employ(new AnotherEmployee("sa"));
            //employeeManagement.Display(employeeManagement.SortBy(SortType.ID));
            employeeManagement.AddPointsTo(3);
            //employeeManagement.Display(employeeManagement.SortBy(SortType.ID));
            var k = (AnotherEmployee)employeeManagement.GetEmployee(0);
            k.SayHello();
               
            EmployeeManagement<AnotherEmployee> employeeManagement1 = new EmployeeManagement<AnotherEmployee>();
            employeeManagement1.Employ("dc");
            employeeManagement1.Employ(new AnotherEmployee3("dd"));
            //employeeManagement1.Display(employeeManagement1.SortBy(SortType.SALARY_ASC));
            //employeeManagement1.Employ(new Employee("aa"));
            Console.WriteLine(employeeManagement1.SortBy(SortType.ID).Count);
            employeeManagement1.Display(employeeManagement1.SortBy(SortType.ID));
            employeeManagement1.GetEmployee(0).SayHello();
        }
    }
    
}

