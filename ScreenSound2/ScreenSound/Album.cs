class Album {

	public Album(string name)
	{
		Name = name;
	}
	private List<Music> musics = new List<Music>();
	public string Name { get; }
	public int Duration => musics.Sum(music => music.Duration);

	public void AddMusic(Music music) {
		musics.Add(music);
	}

	public void ShowMusics(){
		Console.WriteLine($"\nMusic list from album: {Name}");
		foreach (Music music in musics) {
			Console.WriteLine($"Music: {music.Name}");
		}
		Console.WriteLine($"Album duration: {Duration}");
	}
}