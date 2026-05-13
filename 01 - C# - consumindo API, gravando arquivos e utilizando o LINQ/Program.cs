using System.Text.Json;
using Models;

using (HttpClient client = new HttpClient())
{
    try
    {
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        // Console.WriteLine(response);
        List<Musica> musicas = JsonSerializer.Deserialize<List<Musica>>(response)!; // o ponto de exclamação é eu garantindo que a linha não vai vir nula


        // Todos os Generos musicais
        var generos = musicas.Select(musica => musica.Genero);
        List<string> cadaGenero = new List<string>();
        // Passo 1
        foreach (string? genero in generos) {
            Boolean existe = false;
            foreach (string generoExistente in cadaGenero)
            {
                if (genero == generoExistente)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                cadaGenero.Add(genero);
            }
        }
        // Passo 2
        List<string> generoSemRepetir = new List<string>();
        foreach (string generoExistente in cadaGenero)
        {
            string[] cadaGeneroExistente = generoExistente.Split(",");
            foreach (string cadaGeneroExistenteAtual in cadaGeneroExistente)
            {
                Boolean existe = false;
                foreach (string generoSemRepetirAtual in generoSemRepetir)
                {
                    if (generoSemRepetirAtual == cadaGeneroExistenteAtual.Trim())
                    {
                        existe = true;
                    }
                }
                if (!existe)
                {
                    generoSemRepetir.Add(cadaGeneroExistenteAtual.Trim());
                }
            }
        }

        Console.WriteLine("\n\n");
        Console.WriteLine("Aqui estão todos os Gêneros Musicais da Lista:");
        foreach (string generoSemRepetirAtual in generoSemRepetir)
        {
            Console.WriteLine($"Gênero: {generoSemRepetirAtual}");
        }
        

        // Outro método seria:
        var respostaProf01 = musicas.Select(musica => musica.Genero).Distinct().ToList();
        var respostaProf02 = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        var respostaProf03 = musicas.Where(musica => musica.Genero.Contains("pop")).Select(musica => musica.Artista).Distinct().ToList();
        var respostaProf04 = musicas.Where(musica => musica.Artista!.Equals("Eminem")).ToList();

        Console.WriteLine("\n\n");


        // Ordenar os Artistas por nome
        var artistas = musicas.Select(musica => musica.Artista);

        List<string> cadaArtista = new List<string>();
        // Passo 1
        foreach (string? artistaAtual in artistas) {
            Boolean existe = false;
            foreach (string cadaArtistaAtual in cadaArtista)
            {
                if (cadaArtistaAtual == artistaAtual)
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                cadaArtista.Add(artistaAtual);
            }
        }

        // Passo 2
        cadaArtista.Sort();

        foreach (string artistaAtual in cadaArtista)
        {
            Console.WriteLine($"Artista: {artistaAtual}");
        }


        // Filtrar artistas por Gênero musical

        var artistasPorGenero = musicas.Where(musica => musica.Genero == "pop");

        foreach (Musica artistaPorGeneroAtual in artistasPorGenero)
        {
            artistaPorGeneroAtual.ExibirDetalhesDaMusica();
            Console.Write("\n");
        }


        // Filtrar as músicas de um artista

        var musicasPorArtista = musicas.Where(musica => musica.Artista == "Eminem");

        foreach (Musica musicaPorArtistaAtual in musicasPorArtista)
        {
            musicaPorArtistaAtual.ExibirDetalhesDaMusica();
            Console.WriteLine();
        }



        // ........

        MusicasPreferidas musicasFavoritasDoDaniel = new MusicasPreferidas("Daniel");

        musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[1]);
        musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[377]);
        musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[4]);
        musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[6]);
        musicasFavoritasDoDaniel.AdicionarMusicasFavoritas(musicas[1467]);

        musicasFavoritasDoDaniel.ExibirMusicasFavoritas();
        musicasFavoritasDoDaniel.GerarArquivoJson();

        // Desafio final

        Console.WriteLine("Exibindo todas as Músicas com a tonalidade C#: ");
        foreach (Musica musica in musicas)
        {
            if (musica.Tonalidade.Equals("C#"))
            {
                musica.ExibirDetalhesDaMusica();
                Console.WriteLine();
            }
        }

    } catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}