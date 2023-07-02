using System.Text.Json.Serialization;
namespace ScreenSound.Models;

internal class Music
{
    [JsonPropertyName("song")]
   public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public string? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    void ShowMusicDetails() {         
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
