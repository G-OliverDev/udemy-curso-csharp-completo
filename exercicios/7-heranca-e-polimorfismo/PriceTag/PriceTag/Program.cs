using PriceTag.Entities;
using System.Globalization;

namespace PriceTag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = [];

            Console.Write("Enter the number of products: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Product #{i} data:");
                Console.Write("Common, used or imported (c/u/i)? ");
                string response = Console.ReadLine().ToLower();
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (response == "u")
                {
                    Console.Write("Manufacture date (DD/MM/YYYY): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());

                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else if (response == "i")
                {
                    Console.Write("Customs fee: ");
                    double customsFee = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else
                    products.Add(new Product(name, price));
            }

            Console.WriteLine("\nPRICE TAGS:");
            foreach (var product in products)
            {
                Console.WriteLine(product.PriceTag());
            }
        }
    }
}
