using System.Text.Json.Serialization;

namespace Models;

public class Pais
{
    [JsonPropertyName("nome")]
    public string? Name { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    [JsonPropertyName("continente")]
    public string? Continente { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibirDetalhesPais()
    {
        Console.WriteLine($"Nome: {Name}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"População: {Populacao}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine($"Idioma: {Idioma}");
    }
}