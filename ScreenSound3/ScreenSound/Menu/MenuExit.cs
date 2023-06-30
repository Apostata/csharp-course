

using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuExit : Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        Console.WriteLine("Bye bye :)");
    }
}
