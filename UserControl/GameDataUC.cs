namespace SetMouseForGames;

public partial class GameDataUC : UserControl
{

    public Form1 Form1;

    public GameDataUC()
    {
        InitializeComponent();
        ResetScratchpad.Text = LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.Scratchpad_ResetScratchpad);
    }

    private void PasteValueToFirstPersonAimPx_Click(object sender, EventArgs e)
    {
        if (Form1.mainLogic.GamesManager.isSelectedGameNull()) return;

        Form1.mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx = Form1.mainLogic.SpinValue;
        UpdateGameValues();
    }

    private void PasteValueToInGameCursorPx_Click(object sender, EventArgs e)
    {
        if (Form1.mainLogic.GamesManager.isSelectedGameNull()) return;

        Form1.mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx = Form1.mainLogic.SpinValue;
        UpdateGameValues();
    }

    private void CopyFromInGameCursorPx_Click(object sender, EventArgs e)
    {
        if (Form1.mainLogic.GamesManager.isSelectedGameNull()) return;

        Form1.mainLogic.SpinValue = Form1.mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx;
        UpdateMainValueHolder();
    }

    private void CopyFromFirstPersonAimPx_Click(object sender, EventArgs e)
    {
        if (Form1.mainLogic.GamesManager.isSelectedGameNull()) return;

        Form1.mainLogic.SpinValue = Form1.mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx;
        UpdateMainValueHolder();
    }

    internal void UpdateMainValueHolder()
    {
        MainSpinValueHolder.Text = Form1.mainLogic.SpinValue.ToString();

    }

    internal void UpdateGameValues()
    {
        if (Form1.mainLogic.GamesManager.SelectedGameAimSettings is null) return;

        FirstPersonAimPx.Text = Form1.mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx.ToString();
        InGameCursorPx.Text = Form1.mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx.ToString();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        Form1.mainLogic.SpinValue = 0;
        UpdateMainValueHolder();
    }
}
