﻿using System;

class Investimento
{
    public double ValorInvestido { get; set; }
    public double TaxaJuros { get; set; }
    public Investimento(double valorInvestido, double taxaJuros)
    {
        ValorInvestido = valorInvestido;
        TaxaJuros = taxaJuros / 100;
    }
    public double ValorFuturo(int meses)
    {
        return ValorInvestido * Math.Pow(1 + TaxaJuros, meses);
    }
    public double ResgatarRendimento(int mesResgate)
    {
        return ValorFuturo(mesResgate) - ValorInvestido;
    }
    public double SaldoLiquidoRestante(int mesResgate, double mesesTotais)
    {
        return ValorInvestido * Math.Pow(1 + TaxaJuros, mesesTotais - mesResgate);
    }
}

class Program
{
    static void Main()
    {
        Investimento[] investimentos = new Investimento[]
        {
            new Investimento(1000, 3),
            new Investimento(5500, 2.48),
            new Investimento(12000, 2)
        };

        double totalMeses = 8 + (10.0 / 30.0); 
        int mesResgate = 5;

        Console.WriteLine("Valor Presente | Taxa de Juros (%) | Resgate do Rendimento | Saldo Líquido Restante");

        foreach (var investimento in investimentos)
        {
            double resgate = investimento.ResgatarRendimento(mesResgate);
            double saldoRestante = investimento.SaldoLiquidoRestante(mesResgate, totalMeses);

            Console.WriteLine($"{investimento.ValorInvestido}           | {investimento.TaxaJuros * 100:F2}%           | {resgate:F2}                | {saldoRestante:F2}");
        }
    }
}