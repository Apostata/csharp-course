namespace ScreenSound.Models;
using System.Text.Json;

internal class FavoriteMusics
{
    public string? Name { get; set; }
    public List<Music> Musics { get;}

    public FavoriteMusics(string name)
    {
        Name = name;
        Musics = new List<Music>();
    }

    public void AddFavoriteMusic(Music music) {
        Musics.Add(music);
    }

    public void ShowFavoriteMusics()
    {
        Console.WriteLine($"Here is the favorite musics of {Name??"Somebody"}:");
        foreach (Music music in Musics)
        {
            Console.WriteLine($"- {music.Name} by {music.Artist}");
        }
        Console.WriteLine();
    }

    public void GenerateAJsonFile() {             
        // string json = JsonSerializer.Serialize(this);
        string json = JsonSerializer.Serialize( new { name = Name, musics = Musics});
        Console.WriteLine(json);
        string fileName = $"{Name?.ToLower()}-favorite-musics.json";
        File.WriteAllText(fileName, json);
        Console.WriteLine($"File {fileName} generated successfully! in {Path.GetFullPath(fileName)}");
    }
}
