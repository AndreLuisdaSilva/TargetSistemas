using System;
using System.Collections.Generic;

class Desafio4
{
    public static void Executar()
    {
        var estados = new Dictionary<string, double>
        {
            {"SP", 67836.43},
            {"RJ", 36678.66},
            {"MG", 29229.88},
            {"ES", 27165.48},
            {"Outros", 19849.53}
        };

        double total = 0;
        foreach (var valor in estados.Values)
            total += valor;
        Console.WriteLine($"Resultado do Desafio 4:");
        Console.WriteLine("Percentual de representação por estado:");
        foreach (var estado in estados)
        {
            double percentual = (estado.Value / total) * 100;
            Console.WriteLine($"{estado.Key}: {percentual:F2}%");
        }
    }
}
