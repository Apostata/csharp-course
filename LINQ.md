# LINQ
LINQ is a set of extensions to the .NET Framework that encompass language-integrated query, set, and transform operations.
It extends C# and Visual Basic with native language syntax for queries and provides class libraries to take advantage of these capabilities.

LINQ provides the ability to query IEnumerable<T>-based information sources such as arrays, collections, lists, XML information, IQueryables, and more.

## Link Select(Map)
The Select operator is used to transform the elements in a sequence into a new form. It returns a new form of the sequence. 
It is also known as the Map operator in other languages.

## Link Where(Filter)
The Where operator is used to filter a sequence of values based on a predicate. 
It returns a new sequence containing all the elements of the original sequence that satisfy the predicate.

## Link OrderBy(Sort)
The OrderBy operator is used to sort a sequence of values according to a key.

## Link Distinct
The Distinct operator is used to remove duplicate elements from a sequence.

## Link Aggregate
The Aggregate operator is used to apply a function to each element in a sequence.

Examples:
```c#
List<int> numbers = new List<int>(){1,2,3,4,5,6,7,8,9,10};
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

int sum = numbers.Aggregate((acc,curr) => acc + curr);
```
