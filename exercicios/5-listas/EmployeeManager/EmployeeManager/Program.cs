using System.Globalization;

namespace EmployeeManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = [];

            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nEmployee #{i}:");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                employees.Add(new Employee(id, name, salary));
            }

            Console.Write("\nEnter the employee id that will have salary increase: ");
            int searchId = int.Parse(Console.ReadLine());
            Employee employee = employees.Find(x => x.Id == searchId);
            if (employee == null)
                Console.WriteLine("This id does not exist!");
            else
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                employee.IncreaseSalary(percentage);
            }

            Console.WriteLine("\nUpdated list of employees:");
            foreach (var emp in employees)
            {
                Console.WriteLine(emp);
            }
        }
    }
}
