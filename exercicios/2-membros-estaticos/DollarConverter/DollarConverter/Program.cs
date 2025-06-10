using System.Globalization;

namespace DollarConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual é a cotação do dólar? ");
            double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantos dólares você vai comprar? ");
            double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double total = ConversorDeMoeda.DolarParaReal(quantia, cotacao);
            Console.Write("Valor a ser pago em reais = " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
