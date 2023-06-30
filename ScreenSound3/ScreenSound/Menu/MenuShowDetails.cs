
using ScreenSound.Models;
namespace ScreenSound.Menu;
internal class MenuShowDetails : Menu
{
	public override void Exec(Dictionary<string, Band> registeredBands)
	{
        base.Exec(registeredBands);
        ShowHeader("Showing band details");
        Console.Write("Type the band name you want to see the details:");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Band band = registeredBands[bandName];
            Console.WriteLine($"---- \n{bandName} ----");
            Console.WriteLine($"\n{band.Sumary}");
            Console.WriteLine($"\n{string.Empty.PadLeft(bandName.Length + 6, '-')}");
            Console.WriteLine($"\nThe average evaluation of {bandName} is {band.Average}.");
            Console.WriteLine($"\nDiscography:");
            for (int i=0; i<= band.Albums.Count - 1; i++)
            {
                Album album = band.Albums[i];
                Console.WriteLine($"{i + 1} - {album.Name}({album.Average})");
            }
        }
        else
        {
            Console.WriteLine($"\n{bandName} not found!");
        }
    }
}
