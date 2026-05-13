using System.Text.Json.Serialization;

namespace Models;

public class Musica
{
    [JsonPropertyName("song")]
    public string? Name { get; set; }
    [JsonPropertyName("artist")]
    public string? Artista { get; set; }
    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }
    [JsonPropertyName("key")]
    public int Key { get; set; }
    public string? Tonalidade => Key switch 
        {
            0 => "C",
            1 => "C#",
            2 => "D",
            3 => "D#",
            4 => "E",
            5 => "F",
            6 => "F#",
            7 => "G",
            8 => "G#",
            9 => "A",
            10 => "A#",
            11 => "B",
            _ => "Desconhecido"
        };
    [JsonPropertyName("genre")]
    public string? Genero { get; set; }

    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Música: {Name}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração em Segundos: {Duracao / 1000}");
        Console.WriteLine($"Tonalidade: {Tonalidade}");
        Console.WriteLine($"Gênero: {Genero}");
    }
}