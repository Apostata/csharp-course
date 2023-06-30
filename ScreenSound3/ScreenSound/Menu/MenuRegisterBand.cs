using OpenAI_API;
using ScreenSound.Models;
namespace ScreenSound.Menu;

internal class MenuRegisterBand : Menu
{
    public override void Exec(Dictionary<string, Band> registeredBands)
    {
        base.Exec(registeredBands);
        ShowHeader("Registering a new band");
        Console.Write("Type the band name:");
        string bandName = Console.ReadLine()!;
        if (registeredBands.ContainsKey(bandName))
        {
            Console.WriteLine($"\n{bandName} already registered!");
        }
        else
        {
            registeredBands.Add(bandName, new Band(bandName));
            var openAiClient = new OpenAIAPI("YOUR_API_KEY");
            var chat = openAiClient.Chat.CreateConversation();
            chat.AppendSystemMessage($"Sumarize {bandName} band in one paragraph. Adopt an informal style.");
            string bandSumary = chat.GetResponseFromChatbotAsync().GetAwaiter().GetResult();
            registeredBands[bandName].Sumary = bandSumary;
            Console.WriteLine($"\n{bandName} registered!");
        }
    }
}