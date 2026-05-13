using System.Text.Json;
using Models;

using (var client = new HttpClient())
{
    var response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
    Console.WriteLine(response);
    List<Pais> paises = JsonSerializer.Deserialize<List<Pais>>(response)!;

    foreach (Pais paisAtual in paises)
    {
        paisAtual.ExibirDetalhesPais();
        Console.WriteLine();
    }
}