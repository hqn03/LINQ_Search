using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Search.Model
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public int Position {  get; set; }
        public int Department { get; set; }

        public static int Age(DateTime date)
        {
            DateTime now = DateTime.Now;
            int age = now.Year - date.Year;
            if (now.Month < date.Month || (now.Month == date.Month && now.Date < date.Date))
                age--;
            return age;
        }

        public static List<Employee> Employees()
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "John Smith", BirthDay = new DateTime(1985, 4, 15), Position = 3, Department = 1 },
                new Employee { Id = 2, Name = "Emily Johnson", BirthDay = new DateTime(1990, 7, 22), Position = 1, Department = 1 },
                new Employee { Id = 3, Name = "Michael Brown", BirthDay = new DateTime(1982, 11, 10), Position = 4, Department = 1 },
                new Employee { Id = 4, Name = "Sarah Lee", BirthDay = new DateTime(1993, 2, 5), Position = 2, Department = 2 },
                new Employee { Id = 5, Name = "David Wilson", BirthDay = new DateTime(1978, 5, 20), Position = 4, Department = 2 },
                new Employee { Id = 6, Name = "Lisa Garcia", BirthDay = new DateTime(1989, 9, 12), Position = 3, Department = 2 },
                new Employee { Id = 7, Name = "Kevin Chen", BirthDay = new DateTime(1987, 3, 30), Position = 3, Department = 3 },
                new Employee { Id = 8, Name = "Amanda Taylor", BirthDay = new DateTime(1995, 12, 8), Position = 2, Department = 4 },
                new Employee { Id = 9, Name = "Jason Nguyen", BirthDay = new DateTime(1980, 10, 3), Position = 3, Department = 4 },
                new Employee { Id = 10, Name = "Rachel Martinez", BirthDay = new DateTime(1991, 6, 18), Position = 1, Department = 3 },
                new Employee { Id = 11,Name="Sarah Williams",BirthDay=new DateTime(2000,1,1),Position=1,Department=1},
                new Employee { Id = 12,Name="David Jones",BirthDay=new DateTime(2001,1,1),Position=1,Department=2},
                new Employee{Id=13,Name="Jennifer Garcia",BirthDay=new DateTime(1999,1,1),Position=1,Department=3},
                new Employee{Id=14,Name="Christopher Martinez",BirthDay=new DateTime(1999,1,1),Position=1,Department=4},
            };
            return employees;
        }
    }
}
