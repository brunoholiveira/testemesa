﻿using System;

namespace testeDeMesa
{
    public class Program5
    {
        static void Main(string[] args)
        {
            double valorPresente = 3800; 
            double valorFuturo = 7390.61; 
            int periodoMes = 6; 

            double taxaJuros = Math.Pow((valorFuturo / valorPresente), (1.0 / periodoMes)) - 1;
            double numeroMeses = Math.Log(valorFuturo / valorPresente) / Math.Log(1 + taxaJuros);
            Console.WriteLine($"Para obter R$ {valorFuturo} com uma taxa de {taxaJuros * 100:F2}% ao mês, serão necessários aproximadamente {numeroMeses:F2} meses.");
            Console.WriteLine($"Para obter R$ {valorFuturo} em {periodoMes} meses, a taxa de juros necessária é: {taxaJuros * 100:F2}% ao mês");
        }
    }
}