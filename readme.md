# C# .NET course

## Conventions
Variable use camelCase 
Class as functions use PascalCase

## Strings
**Definition:** Strings are immutable, so when you change a string, you are actually creating a new string.

**strings use double quotes while chars use single quotes.**

**Verbatin strings literal:** are preceded by the @ symbol. They are useful when you want to create a string that contains 
backslashes and don't want to escape them as well as when you want to create a multiline string.
Example:
```c#
string logo = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░"
```

contatenation sintax:
```c#
string name = "João";
Console.WriteLine("hi," + name + "!");
```

interpolation sintax:
```c#
string name = "João";
Console.WriteLine($"hi, {name}!");
```

replacing sinxtax: 
```c#
string name = "João";
Console.WriteLine("Olá, {0}!", name);
```

## Arrays
**Definition:** Arrays are fixed size, so you need to specify the size when you create them.
Example:
```c#
int[] numbers = new int[4] { 1, 2, 3, 4 };
Console.WriteLine(numbers[0]); // 1
```

### Array methods
**Length:** returns the size of the array
```c#
int[] numbers = new int[4] { 1, 2, 3, 4 };
Console.WriteLine(numbers.Length); // 4
```
**add:** adds an element to the end of the array
```c#
int[] numbers = new int[4] { 1, 2, 3, 4 };
numbers.Add(5);
Console.WriteLine(numbers[4]); // 5
```

## lists
**Definition:** Lists are similar to arrays, but they are more flexible. Unlike arrays, lists don't have a fixed size.
Example:
```c#
List<int> numbers = new List<int>() { 1, 2, 3, 4 };
Console.WriteLine(numbers[0]); // 1
```

## Dictionaries(key-value pairs)
**Definition:** Dictionaries are used to store key-value pairs. The key is used to find the corresponding value. in other languages they are called `maps`.
Example:
```c#
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>(); // initialize an empty dictionary

Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>() // initialize a dictionary with values
{
	{ "Metallica", new List<int>() { 1, 2, 3, 4 } },
	{ "Iron Maiden", new List<int>() { 2, 1, 3, 4 } }
};

Console.WriteLine(bands["Metallica"]); // 1, 2, 3, 4
Console.WriteLine(bands["Iron Maiden"]); // 2, 1, 3, 4
```	

## Classes
**Definition:** Classes are used to create objects. An object is an instance of a class. its a representation of a real world entity.
class own methods and properties,
methods are functions inside a class
Classes contains properties and attributes.
properties are variables inside a class that can be accessed from outside the class.
attributes are variables inside a class that can only be accessed from inside the class.
Example:
```c#
class Episode{
	public string Title { get; } //property tha can be read from outside the class
	public int Duration { get; } //property tha can be read from outside the class
	public int Order { get; set;} //property tha can be read and write from outside the class
	public string Sumary => $"Episode {Order}: {Title}({Duration}) guests: {string.Join(", ", guests)}"; //property tha can be read from outside the class with a custom getter
	private List<string> guests = new(); //attribute tha can only be read and write from inside the class

	public Episode(string title, int duration){ //constructor
		Title = title;
		Duration = duration;
	}

	public void AddGuest(string guest){ //method
		guests.Add(guest);
	}
}
```

### Constructors
**Definition:** Constructors are special methods that are called when you create an object. They are used to initialize the object.
and they have the same name as the class.

Example:
```c#
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
}
```

### Internal (class modifier)
**Definition:** Internal is an access modifier. It is used to specify that a class or a member can be accessed from the same assembly.
An assembly is a file that contains code. A project can have multiple assemblies. For example, a project can have a library and an executable. 
The library is an assembly that contains code that can be reused by other projects. The executable is an assembly that contains code that can be executed. 
The library can be used by the executable, but not the other way around. 
The library can be used by other projects, but not the executable.


### public (class or member modifier)
**Definition:** Public is an access modifier. It is used to specify that a class or a member can be accessed from any assembly.
Example:
```c#
internal class Episode{
	//class code
}
```

### protected (member modifier)
**Definition:** Protected is an access modifier. It is used to specify that a member can be accessed from the same class or from a derived class.
Example:
```c#
internal class Podcast{
	protected string Title { get; }

	public Podcast(string title){
		Title = title;
	}
	//class code
}

internal class Episode : Podcast{
	//class code
	public void PrintPodcastTitle(){
		Console.WriteLine(Title);
	}
}

PodCast podCast = new('Um podcast');
Episode episode = new();
episode.PrintPodcastTitle(); // Um podcast
```

### private (member modifier)
**Definition:** Private is an access modifier. It is used to specify that a member can be accessed only from the same class.
```c#
internal class Podcast{
	private string Title { get; }

	public Podcast(string title){
		Title = title;
	}
	//class code
}

internal class Episode : Podcast{
	//class code
	public void PrintPodcastTitle(){
		Console.WriteLine(Title);
	}
}

PodCast podCast = new('Um podcast');
Episode episode = new();
episode.PrintPodcastTitle(); // Error
```

### static (member modifier)
**Definition:** Static is a modifier. It is used to specify that a member belongs to the class instead of an object.
Example:
```c#
internal class Podcast{
	public static string title
	//class code
}

Podcast.title = 'Um podcast';
```

### inheritance
**Definition:** Inheritance is a mechanism that allows you to create a new class from an existing class.
in the example below the class Episode inherits from the class Podcast, so the class Episode has all the properties and methods of the class Podcast.
Example:
```c#
internal class Podcast{
	protected string Title { get; }

	public Podcast(string title){
		Title = title;
	}
	//class code
}

internal class Episode : Podcast{
	//class code
	public void PrintPodcastTitle(){
		Console.WriteLine(Title);
	}
}

PodCast podCast = new('Um podcast');
Episode episode = new();
episode.PrintPodcastTitle(); // Um podcast
```


#### override
**Definition:** Override is a modifier. It is used to specify that a method or a property is overriding a method or a property from the base class.
Example:
```c#
internal class Podcast{
	protected string PodCastName { get; }

	public Podcast(string title){
		PodcastName = title;
	}
	
	public string PrintName(){
		return PodcasName;
	}
}

internal class Episode : Podcast{
	public string EpisodeName { get; }

	public Episode(string title){
		EpisodeName = title;
	}

	public override string PrintName(){
		return $"Podcast: {PodcastName}, Episode: {EpisodeName}";
	}
}

PodCast podCast = new('Um podcast');
PodCast.PrintName(); // Um podcast
Episode episode = new('Episode 1');
episode.PrintName(); // Podcast: Um podcast, Episode: Episode 1
```

### sealed
**Definition:** Sealed is a modifier. It is used to specify that a class cannot be inherited.
Example:
```c#
internal sealed class Podcast{
	//class code
}

internal class Episode : Podcast{ // Error
	//class code
}
```

### abstract
**Definition:** Abstract is a modifier. It is used to specify that a class cannot be instantiated. It can only be used as a base class.
Example:
```c#
internal abstract class Podcast{
	//class code
}

internal class Episode : Podcast{ // OK
	//class code
}
```

but if you try to instantiate the class Podcast you will get an error. And Podcast can only be used as a base class. It can't extend another class.

```c#
internal class Channel{
	//class code
}

internal abstract class Podcast : Channel{ //Error
	//class code
}
```

### interface
**Definition:** An interface is a contract. It is used to specify that a class implements a set of methods and properties. 
The class that implements the interface must implement all the methods and properties of the interface.
Example:
```c#
internal interface IPodcast{
	string Title { get; }
	string PrintTitle();
}

internal class Podcast : IPodcast{
	public string Title { get; } // Mandatory

	public Podcast(string title){
		Title = title;
	}

	public string PrintTitle(){ // Mandatory
		return Title;
	}

	public AnotherMethod(){ // Optional
		//method code
	}
}
```

### virtual
**Definition:** Virtual is a modifier. It is used to specify that a method or a property can be overridden by a derived class.
Example:
```c#
internal class Podcast{
	protected string Title { get; }

	public Podcast(string title){
		Title = title;
	}
	
	public virtual string PrintName(){
		return Title;
	}
}
```

### getter and setter
**Definition:** Getter and setter are methods that are used to get and set the value of a property.
Example:
```c#
internal class Podcast{
	private string Title { get; set; }

	public Podcast(string title){
		Title = title;
	}
	
	public string PrintName(){
		return Title;
	}
}
```

#### Lambda expression
**Definition:** Lambda expression is a function that is used to get and set the value of a property.
Example:
```c#
internal class Music
{   

    [JsonPropertyName("song")]
    public string? Name { get; set; }

    [JsonPropertyName("artist")]
    public string? Artist { get; set; }

    [JsonPropertyName("duration_ms")] 
    public int? Duration { get; set; }

    [JsonPropertyName("genre")]
    public string? Genre { get; set; }

    [JsonPropertyName("key")]
    public int? Key { get; set; }

    public string? Tonality => Music.tonalities[Key ?? 0]; // Lambda expression

    public static string[] tonalities = { "C", "C#/Db", "D", "D#/Eb", "E", "F", "F#/Gb", "G", "G#/Ab",  "A", "A#/Bb", "B" };

    public void ShowMusicDetails() {         
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Artist: {Artist}");
        Console.WriteLine($"Duration: {Duration}");
        Console.WriteLine($"Genre: {Genre}");
        Console.WriteLine($"Tonality: {Tonality}");
    }
}
```

#### getter only
**Definition:** Getter only is a modifier. It is used to specify that a property can only be read.
Example:
```c#
internal class Podcast{
	private string Title { get; }

	public Podcast(string title){
		Title = title;
	}
	
	public string PrintName(){
		return Title;
	}
}
```


#### setter only
**Definition:** Setter only is a modifier. It is used to specify that a property can only be written.
Example:
```c#
internal class Podcast{
	private string Title { set; }

	public Podcast(string title){
		Title = title;
	}
	
	public string PrintName(){
		return Title;
	}
}
```

### readonly
**Definition:** Readonly is a modifier. It is used to specify that a field can only be read.

Example:
```c#
internal class Podcast{
	private readonly string Title;

	public Podcast(string title){
		Title = title;
	}
	
	public string PrintName(){
		return Title;
	}
}
```
```

## Namespaces
**Definition:** Namespaces are used to organize code. They are used to avoid name collisions and to create globally unique types.

Example:
```c#
namespace ProjectName.SubNameSpace;

class ClassName{
	//class code
}
```


