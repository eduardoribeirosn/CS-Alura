using (HttpClient client = new HttpClient())
{
    try
    {
        var response = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(response);
    } catch (Exception ex)
    {
        Console.WriteLine("Por que garalhos está dando error");
        Console.WriteLine($"Message Error: {ex.Message}");
    }
}

// Funciona na WEB e POSTMAN. mas quando dou run pelo vscode da erro 404.