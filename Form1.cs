namespace SetMouseForGames;

public partial class Form1 : Form
{

    internal MainLogic mainLogic { get; private set; }

    public Form1()
    {
        mainLogic = new MainLogic(this);
        mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);
        InitializeComponent();
        UpdateMouseInfoLabel();

        new LoadAppDataX(mainLogic);
    }

    protected override void OnHandleCreated(EventArgs e)
    {
        base.OnHandleCreated(e);

        for (int i = 0; i < mainLogic.HotKeysList.Length; i++)
        {
            WindowsAPI.RegisterHotKey(this.Handle, i, mainLogic.HotKeysList[i].ModKeyID, mainLogic.HotKeysList[i].KeyID);
        }
    }

    protected override void WndProc(ref Message m)
    {
        const int WM_HOTKEY = 0x0312;

        if (m.Msg == WM_HOTKEY)
        {
            int id = m.WParam.ToInt32();

            mainLogic.Dosmth((HotKeyEnum)id);
        }

        base.WndProc(ref m);
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
        for (int i = 0; i < mainLogic.HotKeysList.Length; i++)
        {
            WindowsAPI.UnregisterHotKey(this.Handle, i);
        }

        new SaveAppDataX(mainLogic);

        base.OnFormClosing(e);
    }

    internal void RefreshGamesComboBox()
    {
        SelectGameCombo.Items.Clear();

        foreach (var gameName in mainLogic.GamesManager.GamesAimSettingsList.Keys)
        {
            SelectGameCombo.Items.Add(gameName);
        }
    }

    internal void UpdateMainValueHolder()
    {
        MainSpinValueHolder.Text = mainLogic.SpinValue.ToString();

    }

    internal void UpdateGameValues()
    {
        if (mainLogic.GamesManager.SelectedGameAimSettings is null) return;

        FirstPersonAimPx.Text = mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx.ToString();
        InGameCursorPx.Text = mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx.ToString();
    }

    internal void UpdateMouseInfoLabel()
    {

        //mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);

        string messageToPrint = string.Concat($"Mouse speed: {mainLogic.WindowsMouseSettings.WindowsSettingsMouseSpeed.ToString()}/20\n",
            $"Enhanced precision: {mainLogic.WindowsMouseSettings.IsWindowsEnhancePointerPrecisionOn.ToString()}\n",
            $"Scroll speed: {mainLogic.WindowsMouseSettings.WindowsScrollSpeed}lines\n",
            $"Driver DPI: {mainLogic.WindowsMouseSettings.MouseDriverDPI.ToString()}");


        MouseInfoLabel.Text = messageToPrint;
    }

    #region buttons

    private void button1_Click(object sender, EventArgs e)
    {
        UpdateMouseInfoLabel();
    }

    private void SetMouseDpi_Click(object sender, EventArgs e)
    {
        mainLogic.WindowsMouseSettings.GetMouseDPI(MouseDPITextBox.Text);
    }

    #endregion

    #region games buttons

    private void CreateNewGameButton_Click(object sender, EventArgs e)
    {
        mainLogic.GamesManager.AddNewGameToList(EnterGameNameTextBox.Text);
        EnterGameNameTextBox.Text = null;
    }

    private void SelectGameButton_Click(object sender, EventArgs e)
    {
        mainLogic.GamesManager.SelectGame();
    }

    private void DeleteGameFromList_Click(object sender, EventArgs e)
    {
        mainLogic.GamesManager.RemoveGameFromList(SelectGameCombo.Text);
        RefreshGamesComboBox();
        SelectGameCombo.Text = null;
    }

    #endregion

    #region data manipulation buttons

    private void PasteValueToFirstPersonAimPx_Click(object sender, EventArgs e)
    {
        if (mainLogic.GamesManager.isSelectedGameNull()) return;

        mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx = mainLogic.SpinValue;
        UpdateGameValues();
    }

    private void PasteValueToInGameCursorPx_Click(object sender, EventArgs e)
    {
        if (mainLogic.GamesManager.isSelectedGameNull()) return;

        mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx = mainLogic.SpinValue;
        UpdateGameValues();
    }

    private void CopyFromInGameCursorPx_Click(object sender, EventArgs e)
    {
        if (mainLogic.GamesManager.isSelectedGameNull()) return;

        mainLogic.SpinValue = mainLogic.GamesManager.SelectedGameAimSettings.InGameCursorPx;
        UpdateMainValueHolder();
    }

    private void CopyFromFirstPersonAimPx_Click(object sender, EventArgs e)
    {
        if (mainLogic.GamesManager.isSelectedGameNull()) return;

        mainLogic.SpinValue = mainLogic.GamesManager.SelectedGameAimSettings.FirstPersonAimPx;
        UpdateMainValueHolder();
    }

    #endregion

    #region get data from form

    internal string GetSelectGameComboText()
    {
        return SelectGameCombo.Text;
    }

    #endregion

    #region set data to form

    internal void SetGameNameLabel(string gameName)
    {
        SelectedGameNameLabel.Text = $"Selected game profile: {gameName}";
    }

    #endregion

    #region empty
    private void InGameCursorPx_TextChanged(object sender, EventArgs e)
    {

    }

    private void FirstPersonAimPx_TextChanged(object sender, EventArgs e)
    {

    }



    private void label1_Click(object sender, EventArgs e)
    {

    }
    private void FirstPersonAimPx_Click(object sender, EventArgs e)
    {

    }
    private void SelectGameCombo_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    #endregion


}
