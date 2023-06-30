namespace ScreenSound.Models;

internal class Music : IEvaluable
{
    public Music(Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get; }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Sumary => $"A música {Name} pertence à band {Artist}";

    private List<Evaluation> grades = new();

    public double Average =>  grades.Count > 0 ? grades.Average(grade => grade.Value) : 0;

    public void AddGrade(Evaluation grade)
    {
        grades.Add(grade);
    }

    public void ShowMusicDetails()
    {
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
        if (Available)
        {
            Console.WriteLine("Available for streaming");
        } else
        {
            Console.WriteLine("Subcript to premium to listen to this music");
        }
    }
}