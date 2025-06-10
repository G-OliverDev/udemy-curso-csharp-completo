using System.Globalization;

namespace StudentGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double notaFinal = aluno.NotaFinal();
            if (notaFinal >= 60.0)
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine("APROVADO");
            } 
            else
            {
                Console.WriteLine($"NOTA FINAL = {notaFinal.ToString("F2", CultureInfo.InvariantCulture)}");
                Console.WriteLine($"REPROVADO\nFALTARAM {60.0 - notaFinal} PONTOS");
            }               
        }
    }
}
