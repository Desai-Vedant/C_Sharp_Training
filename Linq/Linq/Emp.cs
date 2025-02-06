using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    internal class Emp
    {
        internal int Id;
        internal string FirstName;
        internal string LastName;
        internal Dept DeptName;
        internal Gender EmpGender;
        internal Country EmpCountry;
        internal int Salary;
        internal DateTime DOB;

        internal enum Dept
        {
            IT,
            HR,
            Payroll,
            Engineering,
            Admin,
            Sales
        }

        internal enum Gender
        {
            Male,
            Female,
            Other
        }

        internal enum Country
        {
            IND,
            USA,
            ENG,
            SA,
            AUS,
            NUZ
        }

        public Emp(int id, string firstName, string lastName, Dept dept, Gender gender, Country country, int salary, DateTime dob)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            DeptName = dept;
            EmpGender = gender;
            EmpCountry = country;
            Salary = salary;
            DOB = dob;
        }
    }
}