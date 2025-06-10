using System.Globalization;
using TaxCalculator.Entities;

namespace TaxCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<TaxPayer> taxPayers = [];

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char response = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (response == 'i' || response == 'I')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    taxPayers.Add(new Individual(name, anualIncome, healthExpenditures));
                }
                else if (response == 'c' || response == 'C')
                {
                    Console.Write("Number of employees: ");
                    int numberOfEmployees = int.Parse(Console.ReadLine());

                    taxPayers.Add(new Company(name, anualIncome, numberOfEmployees));
                }
            }

            double totalTaxes = 0.0;
            Console.WriteLine("\nTAXES PAID: ");
            foreach (var taxPayer in taxPayers)
            {
                totalTaxes += taxPayer.Tax();
                Console.WriteLine(taxPayer.Name + ": $ " + taxPayer.Tax().ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine("\nTOTAL TAXES: $ " + totalTaxes.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
