using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Load Data
            EmployeeData employeeData = new EmployeeData();
            var employees = employeeData.employees;

            // Query
            IEnumerable<Emp> nameQuery = from emp in employees
                                         where emp.FirstName.Length == 4
                                         orderby(emp.Salary)
                                         select emp;

            // Execute Query
            foreach (var emp in nameQuery)
            {
                Console.WriteLine(emp.FirstName);
            }

            // Extract Data Query
            IEnumerable<string> extData = from emp in employees
                                          select emp.FirstName + " " + emp.LastName;

            // Execute Query
            foreach (var ext in extData)
            {
                Console.WriteLine(ext);
            }
        }
    }
}
