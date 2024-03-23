using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Search.Model
{
    internal class Department
    {
        public int Id { get; set; }
        public string DName { get; set; }

        public static List<Department> Departments()
        {
            List<Department> departments = new List<Department>
            {
                new Department { Id = 1,DName="Finance"},
                new Department { Id = 2,DName="Human Resources"},
                new Department { Id = 3,DName="Sales"},
                new Department { Id = 4,DName="Marketing"}
            };
            return departments;
        }
    }
}
