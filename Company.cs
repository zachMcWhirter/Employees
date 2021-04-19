using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employees
{
    public class Company
    {
        // Some readonly properties (let's talk about gets, baby)
        public string CompanyName { get; }
        public DateTime CreatedOn { get; }

        // Create a public property for holding a list of current employees
        public List<Employee> Employees = new List<Employee>();


        //Create a constructor method that accepts two arguments:
        //    1. The name of the company
        //    2. The date it was created
        //The constructor will set the value of the public properties
        public Company(string companyName, DateTime created)
        {
            CompanyName = companyName;
            CreatedOn = created;
        }

        // Method to add an employee
        public void Add(Employee employee)
        {
            Employees.Add(employee);
        }

        // Method to list out each employee on the console
        public void ListEmployees()
        {
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName} works for {CompanyName} as a {employee.Title}");
                Console.WriteLine();
            }
        }

    }
}

