using System;

namespace testeDeMesa
{
    public class Program2
    {
        static void Main(string[] args)
        {
            double valorPresente = 3800; 
            double taxaJuros = 1.25 / 100; 
            int periodoMes = 6; 

            double rendaAcumulada = 0;

            Console.WriteLine("Mês\tRendimento\tRend. Líquido\tRenda Acumulada");

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                double rendimento = valorPresente * Math.Pow((1 + taxaJuros), mes); 
                double rendimentoLiquido = rendimento - valorPresente; 
                rendaAcumulada += rendimentoLiquido; 

                Console.WriteLine($"{mes}\tR$ {rendimento:F2}\tR$ {rendimentoLiquido:F2}\tR$ {rendaAcumulada + valorPresente:F2}");
            }
        }
    }
}
