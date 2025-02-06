using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class EmployeeData
    {
        public List<Emp> employees = new List<Emp>
        {
            new Emp(1, "John", "Doe", Emp.Dept.IT, Emp.Gender.Male, Emp.Country.USA, 50000, new DateTime(1990, 5, 21)),
            new Emp(2, "Jane", "Smith", Emp.Dept.HR, Emp.Gender.Female, Emp.Country.IND, 60000, new DateTime(1985, 7, 15)),
            new Emp(3, "Alice", "Brown", Emp.Dept.Sales, Emp.Gender.Female, Emp.Country.AUS, 55000, new DateTime(1992, 3, 10)),
            new Emp(4, "Bob", "Johnson", Emp.Dept.Engineering, Emp.Gender.Male, Emp.Country.NUZ, 70000, new DateTime(1988, 12, 5))
        };
    }
}
