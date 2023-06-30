class Music
{
    public Music( Band artist, string name)
    {
        Artist = artist;
        Name = name;
    }

    public string Name { get;  }
    public Band Artist { get; }
    public int Duration { get; set; }
    public bool Available { get; set; }
    public string Sumary  => $"Music \"{Name}\" from {Artist}"; // get default return


    public void ShowMusic()
    {
        Console.WriteLine($"\nName: {Name}");
        Console.WriteLine($"Artist: {Artist.Name}");
        Console.WriteLine($"Duration: {Duration}");
         Console.WriteLine($"Sumary: {Sumary}");

        if (Available)
        {
            Console.WriteLine("Available on your plan!");
        }
        else
        {
            Console.WriteLine("Sign to the Premium to hear it!");
        }
    }
}