namespace SetMouseForGames;

public class AppSaveInfo
{

    public string SelectedPresetName { get; set; } = null!;

    public Dictionary<string, GamesAimSettings> GamesAimSett { get; set; } = null!;

    public int MouseDPI { get; set; }

    internal void CreateAppSaveInfo(MainLogic mainLogic)
    {
        SelectedPresetName = mainLogic.GamesManager.SelectedGameAimSettings.GameName;
        GamesAimSett = mainLogic.GamesManager.GamesAimSettingsList;
        MouseDPI = mainLogic.WindowsMouseSettings.MouseDriverDPI;
    }

    internal void LoadAppSaveInfo(MainLogic mainLogic)
    {
        mainLogic.GamesManager.GamesAimSettingsList = GamesAimSett.ToDictionary();

        mainLogic.GamesManager.SelectGame(SelectedPresetName);

        mainLogic.WindowsMouseSettings.SetMouseDriverDPI(MouseDPI);
    }
}

internal class BBBBB
{

}
