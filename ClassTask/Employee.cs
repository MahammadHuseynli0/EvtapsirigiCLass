using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class Employee : Department
    {

        public Employee() { }


        public Employee( string name , string surname, byte age, string departmentname, int salary)
        {
            Name = name;
            Surname = surname;
            Age = age;
            DepartmentName = departmentname;
            Salary = salary;
        }

        public string Name;
        public string Surname;
        public byte Age;
        public string DepartmentName;
        public int Salary;
    }
}
