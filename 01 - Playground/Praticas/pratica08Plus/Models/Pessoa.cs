using System.Text.Json;

namespace Models;

public class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Email { get; set; }

    public Pessoa(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    public void ExibirDetalhesPessoa()
    {
        Console.WriteLine();
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        var json = JsonSerializer.Serialize(this);
        string nomeDoArquivo = $"pessoa-{Nome}-{Idade}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"\nArquivo criado com sucesso!!");
        Console.WriteLine($"\nCaminho do Arquivo: {Path.GetFullPath(nomeDoArquivo)}");
    }

    public void LerArquivoJson()
    {
        string textJson = File.ReadAllText($"C:/Users/eduar/OneDrive/Documentos/Estudos/C#/CS-Alura/01 - Playground/Praticas/pratica08Plus/bin/Debug/net10.0/pessoa-{Nome}-{Idade}.json");
        JsonSerializer.Deserialize<Pessoa>(textJson).ExibirDetalhesPessoa();
    }

    public static void GerarJsonListaPessoas(int quantity)
    {
        List<Pessoa> pessoas = new List<Pessoa>();
        for (int i = 0; i < quantity; i++)
        {
            Console.Write("Insira seu Nome: ");
            string nomeUser = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Insira sua Idade: ");
            int.TryParse(Console.ReadLine(), out int idadeUser);
            Console.WriteLine();
            Console.Write("Insira seu E-mail: ");
            string emailUser = Console.ReadLine();
            Console.WriteLine();

            pessoas.Add(new Pessoa(nomeUser, idadeUser, emailUser));
            Console.WriteLine($"Pessoa: {nomeUser} adicionada a Lista, faltam mais {quantity - i - 1}");
            var json = JsonSerializer.Serialize(pessoas);
            File.WriteAllText("listaDePessoas.json", json);
        }
    }

    public static void LerArquivoJsonLista()
    {
        string pathOfFile = $"C:/Users/eduar/OneDrive/Documentos/Estudos/C#/CS-Alura/01 - Playground/Praticas/pratica08Plus/bin/Debug/net10.0/listaDePessoas.json";
        string textJson = File.ReadAllText(pathOfFile);
        List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(textJson);

        Console.WriteLine();
        Console.WriteLine($"Exibindo as pessoas do arquivo JSON:\n\n");
        foreach (Pessoa pessoa in pessoas)
        {
            pessoa.ExibirDetalhesPessoa();
        }
    }

    public static void ExibirPorIdadeLendoArquivoJson()
    {
        Console.Write("\n\nDigite a Idade que gostaria de ver: ");
        int.TryParse(Console.ReadLine(), out int idade);
        Console.WriteLine(" anos");
        Console.WriteLine();


        string pathOfFile = $"C:/Users/eduar/OneDrive/Documentos/Estudos/C#/CS-Alura/01 - Playground/Praticas/pratica08Plus/bin/Debug/net10.0/listaDePessoas.json";
        string textJson = File.ReadAllText(pathOfFile);
        List<Pessoa> pessoas = JsonSerializer.Deserialize<List<Pessoa>>(textJson);

        Console.WriteLine();
        Console.WriteLine($"Exibindo as pessoas do arquivo JSON com {idade} anos:\n\n");
        foreach (Pessoa pessoa in pessoas)
        {
            if (pessoa.Idade == idade)
            {
                pessoa.ExibirDetalhesPessoa();
            }
        }
    }
}