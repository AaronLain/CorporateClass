using System;
using System.Collections.Generic;
using System.Linq;

namespace CorporateClass.Corporate
{
    public class Company
    {
        // Some properties
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a private property for holding a collection of current employees
        private List<Employee> Employees = new List<Employee>();

        public Company(string name)
        {
            Name = name;
            CreatedOn = DateTime.Now;
        }

        // Create a method that allows a caller to add an employee
        public void addEmployee(string name, string jobTitle, DateTime date)
        {
           Employees.Add( new Employee { Name = name, JobTitle = jobTitle, HiringDate = date } );
        }
        // Create a method that allows a caller to remove an employee
        public void removeEmployee(string name)
        {
            Employees.RemoveAll(x => x.Name == name);
        }
        // Create a method that allows a caller to retrieve the list of employees
        public void getAllEmployees()
        {

            foreach (Employee anEmployee in Employees)
            {
                Console.WriteLine($"{anEmployee.Name}, {anEmployee.JobTitle} was hired on: {anEmployee.HiringDate}");

                if (anEmployee.Equals(Employees.Last()))
                {
                    Console.WriteLine("\r\n");
                }
            }
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
 

    }
}
