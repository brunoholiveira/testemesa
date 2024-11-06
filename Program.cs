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
        List<Investimento> investimentos = new List<Investimento>
        {
            new Investimento(1000, 3),
            new Investimento(5500, 2.48),
            new Investimento(12000, 2)
        };

        double totalMeses = 8 + (10.0 / 30.0);
        int mesResgate = 5;

        Console.WriteLine("Valor Investido | Taxa de Juros (%) | Rendimento | Período (a.m.) | Resgate | Saldo Líquido");

        foreach (var investimento in investimentos)
        {
            double rendimento = investimento.ResgatarRendimento(mesResgate);
            double saldoRestante = investimento.SaldoLiquidoRestante(mesResgate, totalMeses);

            Console.WriteLine($"{investimento.ValorInvestido}           | {investimento.TaxaJuros * 100:F2}%           | {rendimento:F2}      | {totalMeses:F2}           | {rendimento:F2}      | {saldoRestante:F2}");
        }
    }
}