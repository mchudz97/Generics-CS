using System;
using System.Collections.Generic;
using System.Linq;

namespace Generics_CS.Gen2
{
    public class EmployeeManagement<T> : IManagement<T> where T : Employee, new()
    {
        private readonly List<T> employees;
        private static int id = 0;
        public EmployeeManagement() 
        {
            this.employees = new List<T>();
        }
        public void AddPointsTo(int id)
        {
            (from employee in this.employees
             where employee.id == id
             select employee).First().AddPoints();
        }

        public void Display(List<T> employees)
        {
            foreach(var employee in employees)
            {
                Console.WriteLine(employee);
            }
            Console.WriteLine("-----------------------------------------------");
        }

        public void Employ(string fullName)
        {
            var e = new T
            {
                id = id++,
                fullName = fullName
            };
            this.employees.Add(e);
        }

        public void Fire(int id)
        {
            var employee = (from e in this.employees
                            where e.id == id
                            select e).First();
            if (this.employees.Contains(employee)) this.employees.Remove(employee);
        }

        public List<T> SortBy(SortType sortType)
        {
            if(sortType == SortType.ID)
            {
                return (from employee in this.employees
                orderby employee.id ascending
                select employee).ToList();
            }
            else if(sortType == SortType.POINT_ASC)
            {
                return (from employee in this.employees
                        orderby employee.points ascending
                        select employee).ToList();
            }
            else if (sortType == SortType.POINT_DESC)
            {
                return (from employee in this.employees
                        orderby employee.points descending
                        select employee).ToList();
            }
            else if (sortType == SortType.SALARY_ASC)
            {
                return (from employee in this.employees
                        orderby employee.salary ascending
                        select employee).ToList();
            }
            else if (sortType == SortType.SALARY_DESC)
            {
                return (from employee in this.employees
                        orderby employee.salary descending
                        select employee).ToList();
            }
            return null;
        }
        
        public void Employ(T employee)
        {
            if (employee is null)
            {
                throw new ArgumentNullException(nameof(employee));
            }

            employee.id = id; 
            this.employees.Add(employee);
        }

        public T GetEmployee(int id)
        {
            return (from employee in this.employees
             where employee.id == id
             select employee).First();
        }
    }
}
