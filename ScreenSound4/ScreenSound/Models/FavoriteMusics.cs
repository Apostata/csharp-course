namespace ScreenSound.Models;
using System.Text.Json;

internal class FavoriteMusics
{
    public string? Nome { get; set; }
    public List<Music> Musics { get;}

    public FavoriteMusics(string name)
    {
        Nome = name;
        Musics = new List<Music>();
    }

    public void AddFavoriteMusic(Music music) {
        Musics.Add(music);
    }

    public void ShowFavoriteMusics()
    {
        Console.WriteLine($"Here is the favorite musics of {Nome??"Somebody"}:");
        foreach (Music music in Musics)
        {
            Console.WriteLine($"- {music.Name} by {music.Artist}");
        }
        Console.WriteLine();
    }

    public void GenerateAJsonFile() {             
       string json = JsonSerializer.Serialize(this);
        Console.WriteLine(json);
        string fileName = $"{Nome?.ToLower()}-favorite-musics.json";
        File.WriteAllText(fileName, json);
        Console.WriteLine($"File {fileName} generated successfully! in {Path.GetFullPath(fileName)}");
    }
}
