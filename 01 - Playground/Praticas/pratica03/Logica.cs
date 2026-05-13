List<int> inteiros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

for (int i = 0; i < inteiros.Count; i++)
{
    Console.Write($"{i}, ");
}

Console.Write("\n\n\n");

Console.Write("Digite o indice que deseja ler: ");
int.TryParse(Console.ReadLine(), out int indice);

try
{
    Console.WriteLine($"O inteiro do Indice {indice} é: {inteiros[indice]}");
}
catch (Exception)
{
    Console.WriteLine("Não foi possível achar o inteiro, Indíce inválido.");
}