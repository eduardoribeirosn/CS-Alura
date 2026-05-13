using System.Text.Json;
using Models;

try
{

    Console.WriteLine($"Seja bem vindo ao meu programa... Lá ele...");

    Console.Write("Insira seu Nome: ");
    string nomeUser = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Insira sua Idade: ");
    int.TryParse(Console.ReadLine(), out int idadeUser);
    Console.WriteLine();
    Console.Write("Insira seu E-mail: ");
    string emailUser = Console.ReadLine();
    Console.WriteLine();

    Pessoa pessoa = new Pessoa(nomeUser, idadeUser, emailUser);
    
    // var json = JsonSerializer.Serialize(pessoa);
    // string nomeDoArquivo = $"pessoa-{nomeUser}-{idadeUser}.json";
    // File.WriteAllText(nomeDoArquivo, json);
    // Console.WriteLine($"\nArquivo criado com sucesso!!");
    // Console.WriteLine($"\nCaminho do Arquivo: {Path.GetFullPath(nomeDoArquivo)}");
    pessoa.GerarArquivoJson();

    // Pt.1 Finalizada

    pessoa.LerArquivoJson();

    // Pt.2 Finalizada

    Pessoa.GerarJsonListaPessoas(6);

    // Pt.3 Finalizada

    Pessoa.LerArquivoJsonLista();

    // Pt.4 Finalizada

    Pessoa.ExibirPorIdadeLendoArquivoJson();

    // Pt.5 Finalizada

} 
catch (Exception)
{
    Console.WriteLine("\nAlgo deu errado...\n");
}