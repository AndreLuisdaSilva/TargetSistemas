using System;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Collections.Generic;

class Desafio3
{
    public class Faturamento
    {
        public double valor { get; set; }
    }

    public static void Executar()
    {
        string json = File.ReadAllText("/home/user/target/TargetDesafio/faturamento.json");
        var faturamentoMensal = JsonSerializer.Deserialize<List<Faturamento>>(json);
        if(faturamentoMensal != null){
            var faturamentosValidos = faturamentoMensal.Where(f => f.valor > 0).ToList();
            double menor = faturamentosValidos.Min(f => f.valor);
            double maior = faturamentosValidos.Max(f => f.valor);
            double media = faturamentosValidos.Average(f => f.valor);
            int diasAcimaMedia = faturamentosValidos.Count(f => f.valor > media);
            Console.WriteLine($"Resultado do Desafio 3:");
            Console.WriteLine($"Menor faturamento: R${menor:F2}");
            Console.WriteLine($"Maior faturamento: R${maior:F2}");
            Console.WriteLine($"Dias acima da média: {diasAcimaMedia}");
        }
    }
}
