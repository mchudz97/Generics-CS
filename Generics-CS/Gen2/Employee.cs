using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_CS.Gen2
{
    public class Employee
    {
        public int id;
        public  int points = 0;
        public string fullName;
        public float salary = 2000;

        public Employee() { }

        public Employee(int id, string fullName, float salary)
        {
            this.id = id;
            this.fullName = fullName;
            this.salary = salary;
        }
        public Employee(string fullName)
        {
            this.fullName = fullName;
        }
        
        public virtual void AddPoints()
        {
            this.points += 5;
        }
        
        public override string ToString()
        {
            return "id: " + this.id +", full name: " + this.fullName + ", salary: " + this.salary + ", points: " + this.points;
        }
        
    }

    public class AnotherEmployee : Employee
    {
        
        public override void AddPoints()
        {
            this.points += 10;
        }
        public AnotherEmployee(string fullName) : base(fullName) 
        { 
            this.salary = 2500; 
        }
        public AnotherEmployee()
        {
            this.salary = 2500;
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }
    }
    public class AnotherEmployee2 : Employee
    {
        public override void AddPoints()
        {
            this.points += 6;
        }
        public AnotherEmployee2(string fullName) : base(fullName)
        {
            this.salary = 3000;
        }
        public AnotherEmployee2()
        {
            this.salary = 3000;
        }
    }
    public class AnotherEmployee3 : AnotherEmployee
    {
        public override void AddPoints()
        {
            this.points += 6;
        }
        public AnotherEmployee3(string fullName) : base(fullName)
        {
            this.salary = 4500;
        }
        public AnotherEmployee3()
        {
            this.salary = 4500;
        }
    }

}
