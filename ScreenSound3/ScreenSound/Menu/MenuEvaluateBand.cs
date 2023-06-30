using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuEvaluateBand : Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        base.Exec(registeredBands);
        ShowHeader("Evaluating a band");
        Console.Write("Type the band name you want to evaluate:");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Console.Write($"what grade do you want to give to the band {bandName}?: ");
            Evaluation grade = Evaluation.Parse(Console.ReadLine()!);
            registeredBands[bandName].AddGrade(grade);
            Console.WriteLine($"\nGrade {grade.Value} registered for {bandName}");

        }
        else
        {
            Console.WriteLine($"\n{bandName} not found!");

        }
    }
}