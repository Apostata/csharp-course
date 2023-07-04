# LINQ
LINQ is a set of extensions to the .NET Framework that encompass language-integrated query, set, and transform operations.
It extends C# and Visual Basic with native language syntax for queries and provides class libraries to take advantage of these capabilities.

LINQ provides the ability to query IEnumerable<T>-based information sources such as arrays, collections, lists, XML information, IQueryables, and more.
Examples:
```c#
List<Music> musics = new List<Music>(){...};
string artist = "The Beatles";

 List<string?> allMusicGenres = musics.Select(music => music.Genre)
            .Distinct()
            .ToList();

List<string?> allArtistsInGenre = musics
            .Where(music => music.Genre!.Contains(genre))
            .Select(music=>music.Artist)
            .Distinct()
            .ToList();

List<Music> allMusicsByArtist = musics
            .Where(music => music.Artist!.Equals(artist))
            .ToList();

List<string?> allArtistsOdernedByName = musics
            .OrderBy(music => music.Artist)
            .Select(music => music.Artist)
            .Distinct()
            .ToList();
```
