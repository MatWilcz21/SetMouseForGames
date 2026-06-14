namespace SetMouseForGames
{
    internal class GamesManager
    {

        internal GamesManager(Form1 _form1)
        {
            form1_ = _form1;
        }

        Dictionary<string, GamesAimSettings> gamesAimSettingsList;
        internal Dictionary<string, GamesAimSettings> GamesAimSettingsList
        {
            get { return gamesAimSettingsList; }
            set
            {
                gamesAimSettingsList = value;
                form1_.addAndSelectGameuc1.RefreshGamesComboBox();
            }
        }
        internal GamesAimSettings SelectedGameAimSettings { get; set; } = null!;

        Form1 form1_;

        internal void AddNewGameToList(string gameName)
        {
            if (!GameNameMethods.IsGameNameValid(gameName))
            {
                MessageBox.Show("Invalid game name", "Error");
                return;
            }

            gameName = GameNameMethods.GetTrimedName(gameName);

            if (IsGameWithThisNameInBase(gameName)) return;


            if (gamesAimSettingsList is null) gamesAimSettingsList = new();
            GamesAimSettingsList.Add(gameName, new GamesAimSettings() { GameName = gameName });

            form1_.addAndSelectGameuc1.RefreshGamesComboBox();
        }

        internal void SelectGame()
        {
            string gameNameToSelect = form1_.addAndSelectGameuc1.GetSelectGameComboText();
            SelectGameByName(gameNameToSelect);
        }

        internal void SelectGame(string gameNameToSelect)
        {
            SelectGameByName(gameNameToSelect);
        }

        void SelectGameByName(string gameNameToSelect)
        {
            if (string.IsNullOrWhiteSpace(gameNameToSelect))
            {
                MessageBox.Show("Select game combo is empty", "Error");
                return;
            }
            if (!form1_.mainLogic.GamesManager.GamesAimSettingsList.TryGetValue(gameNameToSelect, out GamesAimSettings gamesAim)) return;

            form1_.mainLogic.GamesManager.SelectedGameAimSettings = gamesAim;

            form1_.gameDatauc1.UpdateGameValues();
            form1_.addAndSelectGameuc1.SetGameNameLabel(form1_.mainLogic.GamesManager.SelectedGameAimSettings.GameName);
        }

        internal void RemoveGameFromList(string gameName)
        {
            GamesAimSettingsList.Remove(gameName);
        }

        internal bool isSelectedGameNull()
        {

            if (form1_.mainLogic.GamesManager.SelectedGameAimSettings is null)
            {
                MessageBox.Show("Select game is null", "Error");
                return true;
            }
            else return false;
        }

        internal bool IsGameWithThisNameInBase(string gameName)
        {
            if (gamesAimSettingsList.ContainsKey(gameName))
            {
                MessageBox.Show("eX", "Error");
                return true;
            }
            else
                return false;
        }

    }

    internal class GameNameMethods
    {
        static internal bool IsGameNameValid(string gameName)
        {
            if (gameName is null) return false;
            if (gameName.Length == 0) return false;
            if (string.IsNullOrEmpty(gameName)) return false;
            if (string.IsNullOrWhiteSpace(gameName)) return false;

            return true;
        }

        static internal string GetTrimedName(string gameName)
        {
            gameName = gameName.ToLower();
            gameName = gameName.Trim();
            return gameName;
        }
    }

    public record class GamesAimSettings
    {
        public string GameName { get; set; } = null!;
        public int FirstPersonAimPx { get; set; }
        public int InGameCursorPx { get; set; }
    }
}

internal class AAaa
{
    internal static bool IsAnyGameSelected()
    {
        if (!IsGameSelectedFromCombo()) return false;

        return true;
    }

    internal static bool IsGameSelectedFromCombo()
    {



        return true;
    }
}
