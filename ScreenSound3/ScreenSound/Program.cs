using ScreenSound.Menu;
using ScreenSound.Models;

Band acdc = new Band("AC/DC");
Band slot = new Band("The Cult");

acdc.AddGrade(Evaluation.Parse("9"));
Album highwayToHell = new Album("Highway to Hell");
highwayToHell.AddGrade(Evaluation.Parse("10"));
acdc.AddAlbum(highwayToHell);

Dictionary<string, Band> registeredBands = new();
registeredBands.Add(acdc.Name, acdc);
registeredBands.Add(slot.Name, slot);

Dictionary<int, Menu> menu = new();
menu.Add(1, new MenuRegisterBand());
menu.Add(2, new MenuEvaluateBand());
menu.Add(3, new MenuRegisterAlbum());
menu.Add(4, new MenuEvaluateAlbum());
menu.Add(5, new MenuShowBands());
menu.Add(6, new MenuShowDetails());
menu.Add(0, new MenuExit());

void ExibirLogo()
{
    Console.Clear();
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Welcome to Screen Sound 2.0!");
}

void ShowMainMenu()
{
    
    ExibirLogo();
     Console.WriteLine(@"
    type 1 to Register a new band!
    type 3 to Evaluate a band!
    type 2 to Register an album!
    type 4 to Evaluate a band album!
    type 5 to Show all registered bands!  
    type 6 to Show the band details!
    type anything else to exit!
    ");

    Console.Write("Type your option and then hit Enter: ");
     int chosenOption;
    try { chosenOption = int.Parse(Console.ReadLine()!); } catch { chosenOption = 0; };
   
    Menu selectedMenu = menu[chosenOption];
    selectedMenu.Exec(registeredBands);
    if(chosenOption != 0) ReturnToMainMenu();
}


void ReturnToMainMenu()
{
    Console.WriteLine("\nPress any key to return to main menu");
    Console.ReadKey();
    ShowMainMenu();
}


ShowMainMenu();