using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    internal class Person
    {
        private readonly string cnp;
        private readonly string firstName;
        private string lastName;
        private decimal salary;

        public Person(string cnp, string firstName, string lastName)
        {
            this.cnp = cnp;
            this.firstName = firstName;
            this.lastName = lastName;

            this.salary = 500;
        }

        public string Cnp { get { return cnp; } }
        public string FirstName { get { return firstName; } }
        public string LastName { get { return lastName; } }

        public decimal Salary
        {
            get { return salary; }
            private set { salary = value; }
        }

        public void IncreaseSalary()
        {
            //salary = salary * 1.45m;
            //salary *= 1.45m;

            Salary = Salary * 1.45m;
        }

        public void GetMerried(string newName)
        {
            this.lastName = newName;
            IncreaseSalary();
        }
    }
}
