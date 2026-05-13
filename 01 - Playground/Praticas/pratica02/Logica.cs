Console.Write("Digite o 1° Número: ");
int.TryParse(Console.ReadLine(), out int n1);
Console.Write("Digite o 2° Número: ");
int.TryParse(Console.ReadLine(), out int n2);


try
{
    Console.Write($"\n\nA resposta de {n1} / {n2} é: ");
    
    int resposta = n1 / n2;

    Console.WriteLine(resposta);
    // Console.WriteLine("");
} 
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error");
    Console.WriteLine("\nNão foi possível fazer a divisão.");
    Console.WriteLine("\nNão é possível dividir por 0.");
    Console.WriteLine(ex.Message);
}