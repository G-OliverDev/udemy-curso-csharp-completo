using System.Globalization;
using EmployeeDataFilter.Entities;

namespace EmployeeDataFilter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = [];

            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            Console.Write("Enter salary: ");
            double minimalSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] fields = sr.ReadLine().Split(',');
                    string name = fields[0];
                    string email = fields[1];
                    double salary = double.Parse(fields[2], CultureInfo.InvariantCulture);

                    employees.Add(new Employee(name, email, salary));
                }
            }

            var emails = employees.Where(e => e.Salary > minimalSalary).OrderBy(e => e.Name).Select(e => e.Email);
            var sum = employees.Where(e => e.Name[0] == 'M').Select(e => e.Salary).Sum();

            Console.WriteLine($"Email of people whose salary is more than {minimalSalary.ToString("F2", CultureInfo.InvariantCulture)}");
            foreach (string email in emails)
            {
                Console.WriteLine(email);
            }

            Console.WriteLine($"Sum of salary of people whose name starts with 'M': {sum.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
