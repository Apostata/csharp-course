namespace ScreenSound.Models;

internal class Band : IEvaluable
{
    private List<Album> albums = new List<Album>();
    public List<Evaluation> grades { get; } = new List<Evaluation>();

    public string? Sumary { get; set; }

    public Band(string name)
    {
        Name = name;
    }

    public string Name { get; }
    public double Average => grades.Count > 0? grades.Average(grade=>grade.Value): 0;
    public List<Album> Albums => albums;

    public void AddAlbum(Album album) 
    { 
        albums.Add(album);
    }

    public void AddGrade(Evaluation grade)
    {
        grades.Add(grade);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Band discography {Name}");
        foreach (Album album in albums)
        {
            Console.WriteLine($"Album: {album.Name} ({album.TotalDuration})");
        }
    }
}