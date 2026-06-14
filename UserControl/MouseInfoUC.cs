namespace SetMouseForGames;

public partial class MouseInfoUC : UserControl
{

    internal Form1 form1;

    public MouseInfoUC()
    {
        InitializeComponent();
    }

    internal void UpdateMouseInfoLabel()
    {

        //mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);

        string messageToPrint = string.Concat($"Mouse speed: {form1.mainLogic.WindowsMouseSettings.WindowsSettingsMouseSpeed.ToString()}/20\n",
            $"Enhanced precision: {form1.mainLogic.WindowsMouseSettings.IsWindowsEnhancePointerPrecisionOn.ToString()}\n",
            $"Scroll speed: {form1.mainLogic.WindowsMouseSettings.WindowsScrollSpeed}lines\n",
            $"Driver DPI: {form1.mainLogic.WindowsMouseSettings.MouseDriverDPI.ToString()}");


        MouseInfoLabelX.Text = messageToPrint;
    }

    private void button1_Click(object sender, EventArgs e)
    {
        UpdateMouseInfoLabel();
    }

    private void SetMouseDpi_Click(object sender, EventArgs e)
    {
        form1.mainLogic.WindowsMouseSettings.GetMouseDPI(MouseDPITextBox.Text);
    }
}
