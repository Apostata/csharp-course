using System.Text.Json.Serialization;
namespace ScreenSound.Models;



internal class Music
{   

    [JsonPropertyName("song")] // uma Anotação que indica que o atributo song do JSON deve ser mapeado para o atributo Name da classe Music
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")] // uma Anotação que indica que o atributo duration_ms do JSON deve ser mapeado para o atributo Duration da classe Music
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int? Key { get; set; }

    public string? Tonality => Music.tonalities[Key ?? 0];

    public static string[] tonalities = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab",  "A", "A#/Bb", "B" };

    public void ShowMusicDetails() {         
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Tonality: {Tonality}");
    }
}
