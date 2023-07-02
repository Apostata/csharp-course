
using ScreenSound.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
        List<Music>? musics = JsonSerializer.Deserialize<List<Music>>(response);
    }
    catch(HttpRequestException e)
    {
        Console.WriteLine($"Huston! we have a problem: {e.Message}", ConsoleColor.Red);
    }
   
}