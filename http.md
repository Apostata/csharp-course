## HTTP
Http client to make requests to the API.

in C# the http client is `HttpClient` and it is in the `System.Net.Http` namespace.

Example:
```c#
using System.Net.Http;

var client = new HttpClient();
try{
	var response = await client.GetAsync("https://api.github.com/users/aspnet/repos");
	response.EnsureSuccessStatusCode();
	var responseBody = await response.Content.ReadAsStringAsync();
	Console.WriteLine(responseBody);
}
catch(HttpRequestException e){
	Console.WriteLine("\nException Caught!");	
	Console.WriteLine("Message :{0} ",e.Message);
}
```

or

```c#
using (HttpClient client = new HttpClient())
{
	try{
		var response = await client.GetAsync("https://api.github.com/users/aspnet/repos");
		response.EnsureSuccessStatusCode();
		var responseBody = await response.Content.ReadAsStringAsync();
		Console.WriteLine(responseBody);
	}
		catch(HttpRequestException e){
		Console.WriteLine("\nException Caught!");	
		Console.WriteLine("Message :{0} ",e.Message);
	}
}
```
## JSON Serialization and Deserialization
Consider a model class `Music`:
```c#
internal class Music
{
	public string? Name { get; set; }

    public string? Artist { get; set; }

    public int? Duration { get; set; }

    public string? Genre { get; set; }

    public void ShowMusicDetails() {         
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
    }
}
```

and a given response from a requested API:
```json
{
	"song": "The Dark Side of the Moon",
	"artist": "Pink Floyd",
	"duration_ms": 4375,
	"genre": "Progressive Rock, Classic Rock"
}
```
how can we deserialize the response into a `Music` object, since the response is a json string and there are diferente names for the properties?

### Deserialization



```c#
using System.Net.Http;
var client = new HttpClient();

try
{   
    string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    List<Music> musics = JsonSerializer.Deserialize<List<Music>>(response)!;
    ...
    }
    catch(HttpRequestException e)
    {
        Console.WriteLine($"Huston! we have a problem: {e.Message}", ConsoleColor.Red);
    }
```
now we have to update `Music` model class to match the json response, using `JsonPropertyName` attribute, to match the json property name with the C# property name.
```c#

internal class Music
{
   [JsonPropertyName("song")] // this attribute is used to match the json property name. Linking json property song to C# property Name.
	public string? Name { get; set; }

	public string? Artist { get; set; }

	[JsonPropertyName("duration_ms")] // this attribute is used to match the json property name. Linking json property duration_ms to C# property Duration.
	public int? Duration { get; set; }

	public string? Genre { get; set; }

	public void ShowMusicDetails() {         
		Console.WriteLine($"Name: {Name}");
		Console.WriteLine($"Artist: {Artist}");
		Console.WriteLine($"Duration: {Duration}");
		Console.WriteLine($"Genre: {Genre}");
	}
}
```