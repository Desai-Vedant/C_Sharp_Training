using System;

namespace EmployeeApp.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty; // Initialize with a default value
        public DateTime DOB { get; set; }
    }
}