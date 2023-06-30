
using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuEvaluateAlbum : Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        base.Exec(registeredBands);
        ShowHeader("Evaluating an Album");
        Console.Write("Type the band name you want to evaluate:");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Console.Write("Type the album that you want to evaluate:");
            string albumName = Console.ReadLine()!;
            List<Album> albums = registeredBands[bandName].Albums;

            if (albums.Any(album=>album.Name == albumName))
            {
                Album album = albums.First(album => album.Name == albumName);
                Console.Write($"what grade do you want to give to the album {albumName}?: ");
                Evaluation grade = Evaluation.Parse(Console.ReadLine()!);
                album.AddGrade(grade);
                Console.WriteLine($"\nGrade {grade.Value} registered for {albumName}");
            }
            else
            {
                Console.WriteLine($"\n{albumName} not found!");
            }
        }
        else
        {
            Console.WriteLine($"\n{bandName} not found!");

        }
    }
}
