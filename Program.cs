using System;

namespace testeDeMesa
{
    public class Program
    {
        static void Main(string[] args)
        {
            double valorPresente = 1000;
            double taxaJuros = 5.30 / 100;
            int periodoMes = 6;
            //double percentualJuros = 2 / 100;

            double valorFuturo = valorPresente * Math.Pow((1+taxaJuros), periodoMes);
            
            Console.WriteLine("O valor futuro é: " + valorFuturo.ToString("F2"));
        }
    }
}
