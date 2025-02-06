using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace LambdaOperations
{
    internal class Program
    {
        static void SaveEmployeeData(List<Emp> employees)
        {
            string filePath = "employees.json";

            // Save to JSON file
            File.WriteAllText(filePath, JsonSerializer.Serialize(employees, new JsonSerializerOptions { WriteIndented = true }));
            Console.WriteLine("Employees saved to employees.json");
        }

        static void Main(string[] args)
        {
            // Load Data
            EmployeeData employeeData = new EmployeeData();
            var employees = employeeData.employees;

            // Find Max Salary employee
            var maxSalary = employees.Max(emp => emp.Salary);
            var highSalaryEmployee = employees.Where(emp => emp.Salary == maxSalary);

            Console.WriteLine("Employees with heighest salary : ");
            foreach (var emp in highSalaryEmployee) { 
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Dept: {emp.DeptName}, Salary: {emp.Salary}");
            }

            // Find Min Salary employee
            var minSalary = employees.Min(emp => emp.Salary);
            var lowestSalaryEmployee = employees.Where(emp => emp.Salary == minSalary);
            Console.WriteLine("Employees with lowest salary : ");

            foreach (var emp in lowestSalaryEmployee)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Dept: {emp.DeptName}, Salary: {emp.Salary}");
            }

            // Find Female Employee
            var femaleEmployees = employees.Where(emp => emp.EmpGender == Emp.Gender.Female);

            Console.WriteLine("List of Female Employees : ");
            foreach (var emp in femaleEmployees)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Dept: {emp.DeptName}, Salary: {emp.Salary}");
            }

            // Sort employees by salary
            var salarySorted = employees.OrderBy(emp => emp.Salary);

            Console.WriteLine("List of Sorted Employees (By Salary) : ");
            foreach (var emp in salarySorted)
            {
                Console.WriteLine($"{emp.FirstName} {emp.LastName}, Dept: {emp.DeptName}, Salary: {emp.Salary}");
            }

            // Save Data to JSON
            SaveEmployeeData( employees );
        }
    }
}
