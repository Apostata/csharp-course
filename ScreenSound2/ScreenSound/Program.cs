
// Band queen = new Band("Queen");
// Album albumDoQueen = new Album("A night at opera");
// Music loveOfMyLife = new Music(queen, "Love of my life"){
// 	Duration = 213,
// 	Available = true
// };
// Music bohemianRhapsody = new Music(queen, "Bohemian Rhapsody"){
// 	Duration = 354,
// 	Available = false
// };

// albumDoQueen.AddMusic(loveOfMyLife);
// albumDoQueen.AddMusic(bohemianRhapsody);
// loveOfMyLife.ShowMusic();
// bohemianRhapsody.ShowMusic();
// queen.AddAlbum(albumDoQueen);
// queen.ShowAlbums();

Podcast reneCast = new Podcast("Rene host", "ReneCast");
Episode episode1 = new Episode("javascript", 234){
	Order = 1,
};
episode1.AddGuest("Rene");
episode1.AddGuest("Erica");
episode1.AddGuest("Helena");

Episode episode2 = new Episode("dotnet", 342){
	Order = 2,
};
episode2.AddGuest("Rene");
episode2.AddGuest("Diana");

reneCast.AddEpisode(episode1);
reneCast.AddEpisode(episode2);

reneCast.ShowPodcast();