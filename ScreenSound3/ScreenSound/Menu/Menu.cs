using ScreenSound.Models;

namespace ScreenSound.Menu;
internal class Menu
{

    public void ShowHeader(string title)
    {
        string borders = string.Empty.PadLeft(title.Length + 6, '*');
        Console.WriteLine(borders);
        Console.WriteLine($"*  {title}  *");
        Console.WriteLine($"{borders}\n");
    }
    public virtual void Exec(Dictionary<string, Band> registeredBands)
    {
        Console.Clear();
    }
}