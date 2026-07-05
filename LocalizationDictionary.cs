using System.Text.Json;
using static SetMouseForGames.LocalizationDictionary;

namespace SetMouseForGames;

internal class LocalizationDictionary
{
    static Dictionary<LangString, string> localizationDictionary = new();

    internal enum LangString
    {
        NotifyIcon_Show,
        NotifyIcon_Hide,

        SelectGame_SelectedGameProfile,
        SelectGame_AddGame,
        SelectGame_DeleteSelectedGame,

        MouseInfo_MouseDPI,
        MouseInfo_Update,

        MouseInfo_MouseSpeed,
        MouseInfo_MouseEnhancedPrecision,
        MouseInfo_MouseScrollSpeed,
        MouseInfo_MouseDriverDPI,

        Scratchpad_ResetScratchpad,

    }


    internal static string GetLocalization(LangString hardcodedString)
    {

        if (!localizationDictionary.ContainsKey(hardcodedString))
            return hardcodedString.ToString();

        return localizationDictionary[hardcodedString];
    }

    internal static void CreteLocalizationDictionary(string langFileName) =>
        Task.Run(async () => await CreteLocalizationDictionaryAsync(langFileName)).GetAwaiter().GetResult();


    static async Task CreteLocalizationDictionaryAsync(string langFileName)
    {

        string pathToFolderWithLocalizations = Path.Combine(AppContext.BaseDirectory, "Resources", "Localization");

        string pathToFile = Path.Combine(pathToFolderWithLocalizations, $"{langFileName}.json");

        string json = await File.ReadAllTextAsync(pathToFile).ConfigureAwait(false);

        localizationDictionary = JsonSerializer.Deserialize<Dictionary<LangString, string>>(json)
            ?? new Dictionary<LangString, string>();

    }
}

internal class Aucx
{

    internal static void CreateEmptyLocalizationJsonFile(string langFileName)
    {
        Dictionary<LangString, string> data = new();

        foreach (LangString key in Enum.GetValues(typeof(LangString)))
        {
            data.Add(key, "_");
        }

        string json = JsonSerializer.Serialize(data, new JsonSerializerOptions
        {
            WriteIndented = true
        });

        string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        string filePath = Path.Combine(desktopPath, $"{langFileName}.json");

        File.WriteAllText(filePath, json);
    }
}


