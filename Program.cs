﻿using System;

namespace testeDeMesa
{
    public class Program
{
    static void Main()
    {
        double[] entradas = {1000, 5500, 12000};
        double[] taxas = {0.03, 0.0248, 0.02};

        int meses = 8;
        int dias = 10;
        double n_periodos = meses + (dias / 30.0);

        for (int i = 0; i < entradas.Length; i++)
        {
            double valorFuturo = entradas[i] * Math.Pow(1 + taxas[i], n_periodos);
            Console.WriteLine($"Valor Futuro para entrada {entradas[i]} com taxa {taxas[i] * 100}%: {valorFuturo:F2}");
        }
    }
}
}