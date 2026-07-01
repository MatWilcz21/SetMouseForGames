namespace SetMouseForGames;

public partial class AddAndSelectGameUC : UserControl
{

    internal Form1 form1;


    public AddAndSelectGameUC()
    {
        InitializeComponent();
        SelectGameCombo.SelectedIndexChanged += SelectedGameFromComboChanged;

        CreateNewGameButton.Text = LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.SelectGame_AddGame);
        DeleteGameFromList.Text = LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.SelectGame_DeleteSelectedGame);
    }

    private void AddAndSelectGameUC_Load(object sender, EventArgs e)
    {

    }

    private void CreateNewGameButton_Click(object sender, EventArgs e)
    {
        form1.mainLogic.GamesManager.AddNewGameToList(EnterGameNameTextBox.Text);
        EnterGameNameTextBox.Text = null;
    }


    private void SelectedGameFromComboChanged(object sender, EventArgs e)
    {
        form1.mainLogic.GamesManager.SelectGame();
    }

    private void DeleteGameFromList_Click(object sender, EventArgs e)
    {
        form1.mainLogic.GamesManager.RemoveGameFromList(SelectGameCombo.Text);
        RefreshGamesComboBox();
        SelectGameCombo.Text = null;
    }

    internal void RefreshGamesComboBox()
    {
        SelectGameCombo.Items.Clear();

        foreach (var gameName in form1.mainLogic.GamesManager.GamesAimSettingsList.Keys)
        {
            SelectGameCombo.Items.Add(gameName);
        }
    }

    internal string GetSelectGameComboText()
    {
        return SelectGameCombo.Text;
    }

    internal void SetGameNameLabel(string gameName)
    {
        SelectedGameNameLabel.Text = $"{LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.SelectGame_SelectedGameProfile)}: {gameName}";
    }
}
