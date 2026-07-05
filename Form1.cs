namespace SetMouseForGames;

public partial class Form1 : Form
{

    internal MainLogic mainLogic { get; private set; }

    NotifyIconClass notifyIcon1X;

    ///// <summary>
    //CheckMousePosition checkMousePosition1X;
    ///// </summary>

    public Form1()
    {
        LocalizationDictionary.CreteLocalizationDictionary("PL");
        mainLogic = new MainLogic(this);
        mainLogic.WindowsMouseSettings = new WindowsMouseSettings(this);
        InitializeComponent();
        InitOtherForms();


        //new SmoothRot();

        new LoadAppDataX(mainLogic);
        mouseInfouc1.UpdateMouseInfoLabel();
        notifyIcon1X = new NotifyIconClass(this);

        //checkMousePosition1X = CheckMousePosition.CheckMousePositionx;
        //checkMousePosition1X.MouseNotMovedForLongTimeEvent += SSS;
    }

    void InitOtherForms()
    {
        addAndSelectGameuc1.form1 = this;
        mouseInfouc1.form1 = this;
        gameDatauc1.Form1 = this;
    }


    //void SSS()
    //{
    //    MessageBox.Show("za d³ugo nie ruszasz myszk¹");
    //}

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

        #region HOTKEY

        const int WM_HOTKEY = 0x0312;

        if (m.Msg == WM_HOTKEY)
        {
            int id = m.WParam.ToInt32();

            mainLogic.Dosmth((HotKeyEnum)id);
        }

        #endregion
        #region MINIMIZE

        const int WM_SYSCOMMAND = 0x0112;
        const int SC_MINIMIZE = 0xF020;
        if (m.Msg == WM_SYSCOMMAND && (m.WParam.ToInt32() & 0xFFF0) == SC_MINIMIZE)
        {
            notifyIcon1.BalloonTipText = "aaaa";
            Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.Icon = SystemIcons.Application;
            return;
        }
        #endregion

        base.WndProc(ref m);
    }

    internal void ShowApp()
    {
        Show();
        WindowState = FormWindowState.Normal;
        Activate();
        notifyIcon1.Visible = false;
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
