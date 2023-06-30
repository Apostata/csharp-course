class Band{
	public Band(string name){
		Name = name;
	}

	private List<Album> albums = new List<Album>();
	public string Name { get;}
	public void AddAlbum(Album album){
		albums.Add(album);
	}

	public void ShowAlbums(){
		Console.WriteLine($"\nAlbum list from {Name}");
		foreach (Album album in albums) {
			Console.WriteLine($"Album: {album.Name}({album.Duration})");
		}
	}
}