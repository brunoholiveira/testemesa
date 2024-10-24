using System;

namespace testeDeMesa
{
    public class Program4
    {
        static void Main(string[] args)
        {
            double valorPresente = 2000;
            double taxaJuros = 2.00 / 100; 
            int periodoMes = 6; 
            double resgate = 1000; 

            double saldo = valorPresente; 
            double rendimentoAcumulado = 0;

            Console.WriteLine("Mês\tRendimento\tRend. Líquido\tRenda Acumulada\tResgate\tSaldo");

            for (int mes = 1; mes <= periodoMes; mes++)
            {
                double rendimento = saldo * (1 + taxaJuros); 
                double rendimentoLiquido = rendimento - saldo; 
                rendimentoAcumulado += rendimentoLiquido; 

                if (mes == 5)
                {
                    saldo -= resgate; 
                    Console.WriteLine($"{mes}\tR$ {rendimento:F2}\tR$ {rendimentoLiquido:F2}\tR$ {rendimentoAcumulado:F2}\tR$ {resgate:F2}\tR$ {saldo:F2}");
                }
                else
                {
                    saldo = rendimento;
                    Console.WriteLine($"{mes}\tR$ {rendimento:F2}\tR$ {rendimentoLiquido:F2}\tR$ {rendimentoAcumulado:F2}\t-\tR$ {saldo:F2}");
                }
            }
        }
    }
}
