class Episode{
	public string Title { get; }
	public int Duration { get; }
	public int Order { get; set;}
	public string Sumary => $"Episode {Order}: {Title}({Duration}) guests: {string.Join(", ", guests)}"; 
	private List<string> guests = new();

	public Episode(string title, int duration){
		Title = title;
		Duration = duration;
	}

	public void AddGuest(string guest){
		guests.Add(guest);
	}
}