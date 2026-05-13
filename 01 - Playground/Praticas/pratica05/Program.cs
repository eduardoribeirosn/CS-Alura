using System.Text.Json;
using Models;

using (var client = new HttpClient())
{
    var response = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
    List<Filme> filmes = JsonSerializer.Deserialize<List<Filme>>(response);
    foreach (Filme filme in filmes)
    {
        filme.ExibirDetalhesFilme();
        Console.WriteLine();
    }
}