using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

class Exercicio3
{
    class Faturamento
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    static void Main()
    {
        // Lê e desserializa o JSON
        var json = File.ReadAllText("dados.json");
        var lista = JsonSerializer.Deserialize<List<Faturamento>>(json);

        // Ignora dias sem faturamento (valor == 0)
        var valores = lista!
            .Where(f => f.valor > 0)
            .Select(f => f.valor)
            .ToList();

        if (valores.Count == 0)
        {
            Console.WriteLine("Nenhum dia com faturamento.");
            return;
        }

        double menor = valores.Min();
        double maior = valores.Max();
        double media = valores.Average();
        int diasAcimaMedia = valores.Count(v => v > media);

        Console.WriteLine($"Menor faturamento: {menor:F2}");
        Console.WriteLine($"Maior faturamento: {maior:F2}");
        Console.WriteLine($"Dias acima da média ({media:F2}): {diasAcimaMedia}");
    }
}
