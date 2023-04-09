using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetLinqAllAnyApp
{
    public class Employee
    {
        public string? Name { set; get; }
        public int Age { set; get; }
    }

    public class EmployeNameAgeComparer : IEqualityComparer<Employee>
    {
        public bool Equals(Employee? x, Employee? y)
        {
            return x.Name.Equals(y.Name) && x.Age == y.Age;
        }

        public int GetHashCode([DisallowNull] Employee obj)
        {
            return obj.Name.GetHashCode() + obj.Age.GetHashCode();
        }
    }
}
