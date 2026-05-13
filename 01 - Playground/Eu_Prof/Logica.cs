using (HttpClient client = new HttpClient())
{
    try
    {
        var response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.js");
        Console.WriteLine(response);
    } catch (Exception ex)
    {
        Console.WriteLine("Url inválida!");
    }
}