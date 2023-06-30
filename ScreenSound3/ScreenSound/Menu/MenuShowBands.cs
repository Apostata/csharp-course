
using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuShowBands:Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        base.Exec(registeredBands);
        ShowHeader("Showing registered bands");

        foreach (string band in registeredBands.Keys)
        {
            Console.WriteLine($"band: {band}");
        }


    }
}
