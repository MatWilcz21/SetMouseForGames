namespace SetMouseForGames;

internal class MainLogic
{

    internal MainLogic(Form1 _form1)
    {
        GamesManager = new GamesManager(_form1);
        HotKeysList = CreateKeyBinds.CreateKeyBindsX();
        form1 = _form1;
    }

    internal Form1 form1 { get; private set; }

    internal GamesManager GamesManager { get; private set; }

    internal int SpinValue { get; set; }
    int SpinValueChangeScale = 64;

    public HotKeyStruct[] HotKeysList { get; private set; }

    internal WindowsMouseSettings WindowsMouseSettings { get; set; }

    internal void Dosmth(HotKeyEnum hotKeyEnum)
    {

        //MouseSpinClass.DoSpin(6000 * 8 * 2);

        switch (hotKeyEnum)
        {
            case HotKeyEnum.FullRotation:
                DoShowFullSpin();
                break;
            case HotKeyEnum.RotationIncrement:
                Increment(true);
                break;
            case HotKeyEnum.RotationDecrement:
                Increment(false);
                break;

            case HotKeyEnum.RotationScaleIncrement:
                ScaleIncrement(true);
                break;
            case HotKeyEnum.RotationScaleDecrement:
                ScaleIncrement(false);
                break;
            case HotKeyEnum.SaveFile:
                throw new NotImplementedException("no");
                //break;
        }

    }

    void DoShowFullSpin()
    {
        MouseSpinClass.DoSpin(SpinValue);
        Thread.Sleep(300);
    }

    void Increment(bool isIncrementing)
    {
        if (isIncrementing) SpinValue += SpinValueChangeScale;
        else SpinValue -= SpinValueChangeScale;
        DoShowFullSpin();

        form1.UpdateMainValueHolder();
    }

    void ScaleIncrement(bool isIncrementing)
    {

        int change = 2;

        if (isIncrementing) SpinValueChangeScale *= change;
        else SpinValueChangeScale /= change;
    }
}