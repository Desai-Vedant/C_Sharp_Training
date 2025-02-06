using System.Xml;

namespace WebApi.Models
{
    public class Employee
    {
        public required int Id { get; set; }
        public required string FirstName { get; set; }
        public string LastName { get; set; } = string.Empty;
        public string Department { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty ;
        public string Country { get; set; } = string.Empty;
        public int Salary { get; set; }
        public DateTime DOB { get; set; }
    }
}
