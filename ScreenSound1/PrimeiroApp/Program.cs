// Screen sound


string welcomeMessage = @"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░";


// List<string> bands = new List<string>();
// List<string> bands = new List<string> {"Slot", "Battle Beast"};
Dictionary<string, List<int>> bands = new Dictionary<string, List<int>>() // or new()
{
    {"Slot",  new List<int>{10, 9 } },
    {"Battle Beast", new List<int>() },
};
;
void ShowLogo()
{
    Console.Clear();
    Console.WriteLine(welcomeMessage);
    Console.WriteLine("\nWelcome to Screen Sound!\n");
}

void ShowMenuOptions()
{
    ShowLogo();
    Console.WriteLine(@"
    type 1 to register a new band!
    type 2 to show all registered bands!
    type 3 to evaluate a band!  
    type 4 to show the band average!
    type anything else to exit!
    ");

    Console.Write("Type your option and then hit Enter: ");
    int chosenOption = 0;
    try { chosenOption = int.Parse(Console.ReadLine()!); } catch { chosenOption = 0; };
    switch (chosenOption)
    {
        case 1:
            RegisterBand();
            break;
        case 2:
            ShowRegisteredBands();
            break;
        case 3:
            EvaluateBand();
            break;
        case 4:
            ShowdBandAverage();
            break;
        default:
            Console.WriteLine("\nExit!");
            break;
    }
}

void ShowHeader(string title)
{
    Console.Clear();
    string borders = string.Empty.PadLeft(title.Length + 6, '*');
    Console.WriteLine(borders);
    Console.WriteLine($"*  {title}  *");
    Console.WriteLine($"{borders}\n");
}

void RegisterBand()
{
    ShowHeader("Register a new band!");
    Console.Write("Type the band name: ");
    string entenredBand = Console.ReadLine()!;
    bands.Add(entenredBand, new List<int>());
    Console.WriteLine($"\n{entenredBand} as successfuly registered!");
    AwaitUserAction();
}

void ShowRegisteredBands()
{
    ShowHeader("Showing all bands");

    int i = 0;
    foreach (string band in bands.Keys)
    {
        i++;
        Console.WriteLine($"{i}: {band}");
    }
    AwaitUserAction();
}

void AwaitUserAction()
{
    Console.WriteLine("\nPress any key to return to main menu!");
    Console.ReadKey();
    ShowMenuOptions();
}

void EvaluateBand()
{
    ShowHeader("Evaluate a band!");
    Console.Write("Type the band name: ");
    string entenredBand = Console.ReadLine()!;

    if (bands.ContainsKey(entenredBand))
    {
        Console.WriteLine($"\nYou chose {entenredBand} to evaluate!");
        Console.Write("Type the band grade: ");
        int grade = 0;
        try { grade = int.Parse(Console.ReadLine()!); } catch { grade = 0; };
        bands[entenredBand].Add(grade);
        Console.WriteLine($"\n{entenredBand} was evaluated with {grade}");
        string gradeMessage = grade >= 6 ? $"{entenredBand} rocks!" : $"{entenredBand} is not that good humm!";
        Console.WriteLine($"{gradeMessage}\n");
    }
    else
    {
        Console.WriteLine($"\n{entenredBand} was not found!");
        Thread.Sleep(1000);
    }

    AwaitUserAction();
}

void ShowdBandAverage()
{
    ShowHeader("Show the band grade and Average");

    Console.Write("Type the band name: ");
    string band = Console.ReadLine()!;
    if (bands.ContainsKey(band))
    {
        ShowHeader($"Showing {band} average!");
       // string listOfGradesForGivinBand = bands[band].Aggregate(string.Empty, (string acc, int item) => $"{acc} {item},");
        string listOfGradesForGivinBand = String.Join(",", bands[band]);
        Console.WriteLine($"\n{band} has {bands[band].Count} grades! Respectively {listOfGradesForGivinBand}.");
        double average = bands[band].Average();
        Console.WriteLine($"\nThe average of {band} is {average}");

    }
    else
    {
        Console.WriteLine($"\n{band} was not found!");
        Thread.Sleep(1000);
    }
    AwaitUserAction();
}

ShowMenuOptions();


