using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get { return this.name; } }
        public decimal Salary { get { return this.salary; } }
        public string Position { get { return this.position; } }
        public string Department { get { return this.department; } }
        public string Email { get { return this.email; } }
        public int Age { get { return this.age; } }


        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary =Math.Round(salary, decimals: 2) ;
            this.position = position;
            this.department = department;
            this.email = "n/a";
            this.age = -1;
        }
        public Employee(string name, decimal salary, string position, string department,int age):this(name,salary,position,department)
        {
            this.age = age;
        }
        public Employee(string name, decimal salary, string position, string department, string email) : this(name, salary, position, department)
        {
            this.email = email;
        }
        public Employee(string name, decimal salary, string position, string department, string email,int age) : this(name, salary, position, department)
        {
            this.age = age;
            this.email = email;
        }
    }
}
