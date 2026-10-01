using System;
using System.Collections.Generic;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Employee Manager");
                Console.WriteLine("1.Add Employee");
                Console.WriteLine("2.List Employee");
                Console.WriteLine("3.Remove Employee");
                Console.WriteLine("4.Quit");
                Console.Write("Enter your choice:");

                string choice = Console.ReadLine()??"";

                if (choice == "4")
                {
                    break;
                }
                if (choice != "1")
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }
            }
            string name;

            while (true)
            {
                Console.Write("Employee Name: ");
                name = Console.ReadLine() ?? "";

                if (Employee.IsvalidName(name))
                    break;
                Console.WriteLine("Invalid name! Enter 1-50 characters.");
            }

            string id;
            
            while (true)
            {
                Console.Write("Employee Id:");
                id = Console.ReadLine() ?? "";

                if (id.Length == 3 &&
                    char.IsLetter(id[0]) &&
                    char.IsDigit(id[1]) &&
                    char.IsDigit(id[2]))
                    break;
                Console.WriteLine("Invalid ID! Example : D65");
            }
            double hours;

            while(true)
            {
                Console.Write("Hours Worked: ");

                if (double.TryParse(Console.ReadLine(), out hours)
                    && hours >= 1 && hours <= 100)
                    break;

                Console.WriteLine("Hours must be between 1 and 100.");
            }
        
        

            Employee employee = new Employee(name, id, hours);
            employees.Add(employee);
            Console.WriteLine();
            Console.WriteLine("Employee Name:" + employee.EmployeeName);
            Console.WriteLine("Employee Id:" + employee.EmployeeID);
            Console.WriteLine("Hours Worked:" + employee.HoursWorked);
            Console.WriteLine("The weekly wage is £" + employee.Calculatewage().ToString("F2"));
        }
    }
}
