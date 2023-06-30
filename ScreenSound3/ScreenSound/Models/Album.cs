namespace ScreenSound.Models;

internal class Album : IEvaluable
{
    private List<Music> musics = new();

    private List<Evaluation> grades = new();

    public Album(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public int TotalDuration => musics.Sum(m => m.Duration);
    public List<Music> Musics => musics;

    public double Average => grades.Count > 0 ? grades.Average(evaluation => evaluation.Value) : 0;

    public void AddGrade(Evaluation grade)
    {
        grades.Add(grade);
    }

    public void AdicionarMusic(Music music)
    {
        musics.Add(music);
    }

    public void ExibirMusicsDoAlbum()
    {
        Console.WriteLine($"Music list from album {Name}:\n");
        foreach (var music in musics)
        {
            Console.WriteLine($"Musics: {music.Name}");
        }
        Console.WriteLine($"\nAlbum duration {TotalDuration}");
    }
}