namespace SetMouseForGames;

public partial class MouseInfoUC : UserControl
{

    internal Form1 form1;

    public MouseInfoUC()
    {
        InitializeComponent();

        SetMouseDpi.Text = LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_MouseDPI);
        UpdateMouseInfo.Text = LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_Update);
    }

    internal void UpdateMouseInfoLabel()
    {

        //mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);

        string messageToPrint = string.Concat
        (
            $"{LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_MouseSpeed)}: {form1.mainLogic.WindowsMouseSettings.WindowsSettingsMouseSpeed.ToString()}/20\n",
            $"{LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_MouseEnhancedPrecision)}: {form1.mainLogic.WindowsMouseSettings.IsWindowsEnhancePointerPrecisionOn.ToString()}\n",
            $"{LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_MouseScrollSpeed)}: {form1.mainLogic.WindowsMouseSettings.WindowsScrollSpeed}lines\n",
            $"{LocalizationDictionary.GetLocalization(LocalizationDictionary.LangString.MouseInfo_MouseDriverDPI)}: {form1.mainLogic.WindowsMouseSettings.MouseDriverDPI.ToString()}"
        );


        MouseInfoLabelX.Text = messageToPrint;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        UpdateMouseInfoLabel();
    }

    private void SetMouseDpi_Click(object sender, EventArgs e)
    {
        form1.mainLogic.WindowsMouseSettings.GetMouseDPI(MouseDPITextBox.Text);
        UpdateMouseInfoLabel();
    }
}
