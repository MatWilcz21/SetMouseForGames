namespace SetMouseForGames;

public partial class Form1 : Form
{

    internal MainLogic mainLogic { get; private set; }

    public Form1()
    {
        mainLogic = new MainLogic(this);
        mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);
        InitializeComponent();
        InitOtherForms();

        InitOtherForms();



        new LoadAppDataX(mainLogic);
        mouseInfouc1.UpdateMouseInfoLabel();
    }

    void InitOtherForms()
    {
        addAndSelectGameuc1.form1 = this;
        mouseInfouc1.form1 = this;
        gameDatauc1.Form1 = this;
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

    private void addAndSelectGameuc1_Load(object sender, EventArgs e)
    {

    }
}
