using System;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using System.Text.Json;
using System.Collections.Generic;

class Desafio3
{
    public class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public static void Executar()
    {
        string caminhoArquivo = "dados.json"; // ou "dados.xml"
        List<Faturamento> faturamentoMensal;

        if (caminhoArquivo.EndsWith(".json"))
        {
            string json = File.ReadAllText(caminhoArquivo);
            faturamentoMensal = JsonSerializer.Deserialize<List<Faturamento>>(json);
        }
        else if (caminhoArquivo.EndsWith(".xml"))
        {
            var doc = XDocument.Load(caminhoArquivo);
            faturamentoMensal = doc.Descendants("row")
                .Select(x => new Faturamento
                {
                    dia = int.Parse(x.Element("dia").Value),
                    valor = double.Parse(x.Element("valor").Value.Replace('.', ','))
                })
                .ToList();
        }
        else
        {
            Console.WriteLine("Formato de arquivo não suportado. Use .json ou .xml");
            return;
        }

        var faturamentosValidos = faturamentoMensal.Where(f => f.valor > 0).ToList();

        if (!faturamentosValidos.Any())
        {
            Console.WriteLine("Nenhum dia com faturamento válido encontrado.");
            return;
        }

        double menor = faturamentosValidos.Min(f => f.valor);
        double maior = faturamentosValidos.Max(f => f.valor);
        double media = faturamentosValidos.Average(f => f.valor);
        int diasAcimaMedia = faturamentosValidos.Count(f => f.valor > media);

        Console.WriteLine($"Menor faturamento: R$ {menor:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaMedia}");
    }
}
