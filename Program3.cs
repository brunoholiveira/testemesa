using System;

namespace testeDeMesa
{
    public class Program3
    { 
        static void Main(string[] args)
        {
            Console.Write("Digite o valor presente (R$): ");
            double valorPresente = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite a taxa de juros (% a.a.): ");
            double taxaJuros = Convert.ToDouble(Console.ReadLine()) / 100;

            Console.Write("Digite o período (em anos): ");
            int periodoAnos = Convert.ToInt32(Console.ReadLine());

            double valorFuturo = valorPresente * Math.Pow((1 + taxaJuros), periodoAnos);
            double rendimento = valorFuturo - valorPresente;

            Console.WriteLine($"\nRendimento total após {periodoAnos} anos: R$ {rendimento:F2}");
            Console.WriteLine($"Valor futuro: R$ {valorFuturo:F2}");
        }
    }
}
