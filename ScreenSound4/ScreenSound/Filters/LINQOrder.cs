
using ScreenSound.Models;

namespace ScreenSound.Filters;

internal class LinqOrder
{
    public static void ShowAllArtistsOrdenedByName(List<Music> musics)
    {
        List<string?> allArtistsOderned = musics
            .OrderBy(music => music.Artist)
            .Select(music => music.Artist)
            .Distinct()
            .ToList();

        Console.WriteLine("Ordened list of artists");
        foreach(string? artist  in allArtistsOderned)
        {
            Console.WriteLine($"- {artist}");
        }
    }
}
