using System.Text.Json.Serialization;

namespace Models;

public class Filme
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
    [JsonPropertyName("rank")]
    public string? Posicao { get; set; }
    [JsonPropertyName("fullTitle")]
    public string? Title { get; set; }
    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    public void ExibirDetalhesFilme()
    {
        Console.WriteLine($"Id: {Id}");
        Console.WriteLine($"Posição: {Posicao}");
        Console.WriteLine($"Título: {Title}");
        Console.WriteLine($"Nota: {Nota}");
    }
}