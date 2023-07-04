namespace ScreenSound.Filters;
using ScreenSound.Models;

internal class LinqFilter
{
    public static void ShowAllMusicGenres(List<Music> musics)
    {
        List<string?> allMusicGenres = musics.Select(music => music.Genre)
            .Distinct()
            .ToList();
        foreach (string? genre in allMusicGenres)
        {
            Console.WriteLine(genre);
        }
    }

    public static void ShowAllArtistsByGenre(List<Music> musics, string genre)
    {
        List<string?> allArtistsInGenre = musics
            .Where(music => music.Genre!.Contains(genre))
            .Select(music=>music.Artist)
            .Distinct()
            .ToList();
        Console.WriteLine($"All artists in genre ${genre}");
        foreach(string? artist in allArtistsInGenre)
        {
            Console.WriteLine($"- {artist}");
        }
    }

    public static void ShowAllMusicsByArtist(List<Music> musics, string artist)
    {
        List<Music> allMusicsByArtist = musics
            .Where(music => music.Artist!.Equals(artist))
            .ToList();
        Console.WriteLine($"Musics from {artist}");
        foreach(Music music in allMusicsByArtist)
        {
            Console.WriteLine($"- {music.Name} by {music.Artist}");
        }
    }
}
