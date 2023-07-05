
using ScreenSound.Models;
using System.Text.Json;
using ScreenSound.Filters;

using System.Net.Http;
var client = new HttpClient();

try
{   
    string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
    // LinqFilter.ShowAllMusicGenres(musics);
    // LinqOrder.ShowAllArtistsOrdenedByName(musics);
    // LinqFilter.ShowAllArtistsByGenre(musics, "blues");
    // LinqFilter.ShowAllMusicsByArtist(musics, "Michael Jackson");
    LinqFilter.ShowAllMusicsByTonality(musics, 1); // 1 = C#

    //FavoriteMusics favoriteMusicOfRene = new("Rene");
    //favoriteMusicOfRene.AddFavoriteMusic(musics[1]);
    //favoriteMusicOfRene.AddFavoriteMusic(musics[377]);
    //favoriteMusicOfRene.AddFavoriteMusic(musics[4]);
    //favoriteMusicOfRene.AddFavoriteMusic(musics[6]);
    //favoriteMusicOfRene.AddFavoriteMusic(musics[1467]);
    //favoriteMusicOfRene.ShowFavoriteMusics();
    //favoriteMusicOfRene.GenerateAJsonFile();
    }
    catch(HttpRequestException e)
    {
        Console.WriteLine($"Huston! we have a problem: {e.Message}", ConsoleColor.Red);
    }
   
