
using ScreenSound.Models;

namespace ScreenSound.Menu;

internal class MenuRegisterAlbum : Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        base.Exec(registeredBands);
        ShowHeader("Album registration");
        Console.Write("Type the band name to register the album:");
        string bandName = Console.ReadLine()!;
        Console.Write("Type the album title:");
        string albumTitle = Console.ReadLine()!;

        if (registeredBands.ContainsKey(bandName))
        {
            registeredBands[bandName].AddAlbum(new Album(albumTitle));
            Console.WriteLine($"Album {albumTitle} from {bandName} was registered!");
        }
        else
        {
            Console.WriteLine($"\n{bandName} not found!");
        }
    }
}
