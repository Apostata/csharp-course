class Podcast{
	public string Host {get;}
	public string Name {get;}
	private List<Episode> episodes = new();

	public Podcast(string host, string name){
		Host = host;
		Name = name;
	}

	public void AddEpisode(Episode episode){
		episodes.Add(episode);
	}

	public void ShowPodcast(){
		Console.WriteLine($"\nPodcast: {Name} by {Host}");

		Console.WriteLine("\nList of Episodes:");
		foreach (Episode episode in episodes.OrderBy(episode => episode.Order)) {
			Console.WriteLine(episode.Sumary);
		}
		Console.WriteLine($"\nNumber of Episodes: {episodes.Count}");
	}
}