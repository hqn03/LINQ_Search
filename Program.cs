using LINQ_Search.Model;
using System.Numerics;

namespace LINQ_Search
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input;
			List<Position> positions = Position.Positions();
			List<Department> departments = Department.Departments();
			List<Employee> employees = Employee.Employees();
            		Console.Write("Enter your keyword search: ");
			string? keyword = Console.ReadLine().ToLower();
			Console.Write("Age from: ");
			input = Console.ReadLine();
			int? ageFrom = input.Equals("") ? null : Convert.ToInt16(input); 
			Console.Write("To: ");
			input = Console.ReadLine();
			int? ageTo = input.Equals("") ? null : Convert.ToInt16(input);
			Console.Write("Enter position 1.Officer\t2.Team Leader\t3.Manager\t4.Director\nPosition: ");
			input = Console.ReadLine();
			int? position = input.Equals("") ? null : Convert.ToInt16(input);
			Console.Write("Enter department 1.Finance\t2.Human resource\t3.Sales\t4.Marketing\nDepartment: ");
			input = Console.ReadLine();
			int? department = input.Equals("") ? null : Convert.ToInt16(input);

			var employeesSearch = from emp in employees
								  join dep in departments on emp.Department equals dep.Id
								  join pos in positions on emp.Position equals pos.Id
								  where (emp.Name.ToLower().Contains(keyword) ||
								  dep.DName.ToLower().Contains(keyword) || 
								  pos.PName.ToLower().Contains(keyword)) &&
								  (!ageFrom.HasValue || ageFrom<=Employee.Age(emp.BirthDay)) &&
								  (!ageTo.HasValue || ageTo>=Employee.Age(emp.BirthDay)) &&
								  (!position.HasValue || position==pos.Id) &&
								  (!department.HasValue || department==dep.Id)
								  select new { emp.Id, emp.Name, emp.BirthDay, pos.PName, dep.DName };

			Console.WriteLine("+------+--------------------+---------------+-----+---------------+---------------+");
			Console.WriteLine("|  ID  |       Name         |    BirthDay   | Age |    Position   |  Department   |");
			Console.WriteLine("+------+--------------------+---------------+-----+---------------+---------------+");


			foreach (var x in employeesSearch)
			{
                Console.WriteLine("|{0,-6}|{1,-20}|{2,-15}|{3,-5}|{4,-15}|{5,-15}|", x.Id.ToString(),x.Name,DateOnly.FromDateTime(x.BirthDay),Employee.Age(x.BirthDay),x.PName,x.DName);
            }
			Console.WriteLine("+------+--------------------+---------------+-----+---------------+---------------+");
		}
	}
}
