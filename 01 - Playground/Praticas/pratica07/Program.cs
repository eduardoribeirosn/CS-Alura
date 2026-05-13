using System.Text.Json;
using Models;

using (var client = new HttpClient())
{
    var response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
    List<Carro> carros = JsonSerializer.Deserialize<List<Carro>>(response)!;

    foreach (Carro carro in carros)
    {
        carro.ExibirDetalhesCarro();
        Console.WriteLine();
    }
}