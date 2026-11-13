using System;
using System.Collections.Generic;
using System.Text;

namespace LearningC_.OOPS
{

    using System;

    class Employee
    {
        // EmployeeId cannot be changed after object creation
        public int EmployeeId { get; }

        // EmployeeName can be read but cannot be modified outside the class
        public string EmployeeName { get; private set; }

        // Salary cannot be modified directly outside the class
        public decimal Salary { get; private set; }

        // Constructor
        public Employee(int employeeId, string employeeName, decimal salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Salary = salary;
        }

        // Method to increase salary
        public void IncreaseSalary(decimal amount)
        {
            if (amount > 0)
            {
                Salary += amount;
                Console.WriteLine("Salary increased successfully!");
            }
            else
            {
                Console.WriteLine("Salary increase amount must be greater than zero.");
            }
        }

        // Method to display employee details
        public void DisplayEmployeeDetails()
        {
            Console.WriteLine("\nEmployee Details");
            Console.WriteLine("------------------------");
            Console.WriteLine("Employee ID   : " + EmployeeId);
            Console.WriteLine("Employee Name : " + EmployeeName);
            Console.WriteLine("Salary        : " + Salary);
        }
    }

    /*class Program
    {
        static void Main(string[] args)
        {
            // Creating Employee object
            Employee emp = new Employee(101, "Rahul", 30000);

            // Display employee details
            emp.DisplayEmployeeDetails();

            // Increase salary
            emp.IncreaseSalary(5000);

            // Display updated employee details
            emp.DisplayEmployeeDetails();

            // Invalid salary increase
            emp.IncreaseSalary(-2000);

            // These statements are not allowed:
            // emp.EmployeeId = 102;
            // emp.EmployeeName = "Amit";
            // emp.Salary = 50000;
        }
    }*/

}
