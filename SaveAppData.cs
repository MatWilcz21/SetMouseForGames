namespace SetMouseForGames;

using System.IO;
using System.Text.Json;
internal class SaveAppDataX
{

    internal SaveAppDataX(MainLogic _mainLogic) => SaveApp(_mainLogic);



    internal void SaveApp(MainLogic _mainLogic)
    {

        AppSaveInfo appSaveInfo = new AppSaveInfo();
        appSaveInfo.CreateAppSaveInfo(_mainLogic);

        string json = JsonSerializer.Serialize(appSaveInfo, new JsonSerializerOptions
        {

            WriteIndented = true
        });

        File.WriteAllText(CCCC.GetSaveAppDataPath(), json);
    }
}

internal class LoadAppDataX
{

    internal LoadAppDataX(MainLogic _mainLogic) => LoadApp(_mainLogic);

    internal void LoadApp(MainLogic _mainLogic)
    {


        if (!File.Exists(CCCC.GetSaveAppDataPath()))
        {
            MessageBox.Show("Hello");
            return;
        }
        string a = File.ReadAllText(CCCC.GetSaveAppDataPath());

        AppSaveInfo appsa = JsonSerializer.Deserialize<AppSaveInfo>(a)!;


        appsa.LoadAppSaveInfo(_mainLogic);

    }
}

internal class CCCC
{

    static string configFileName = "ConfigFile";

    internal static string GetSaveAppDataPath() => Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{configFileName}.json");

}




