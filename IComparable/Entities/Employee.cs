using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace IComparablee.Entities
{
    class Employee : IComparable
    {
        public string Name { get; set; }
        public double Salary { get; set; }

        public Employee(string csvEMployee)
        {
            string[] vect = csvEMployee.Split(',');
            Name = vect[0];
            Salary = double.Parse(vect[1], CultureInfo.InvariantCulture);

        }
        public override string ToString()
        {
            return "Name: " + Name + ", Salary: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj)
        {
            if(!(obj is Employee))
            {
                throw new ArgumentException("Comparing error: argument is nor an employee");
            }
            Employee other = obj as Employee;
            return Salary.CompareTo(other.Salary);
        }
    }
}
