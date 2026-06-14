namespace SetMouseForGames;

internal class MainLogic
{

    internal MainLogic(Form1 _form1)
    {
        GamesManager = new GamesManager(_form1);
        HotKeysList = CreateKeyBinds.CreateKeyBindsX();
        form1 = _form1;


        rotationEngine = new SimpleStepper(this);
    }

    internal Form1 form1 { get; private set; }

    internal GamesManager GamesManager { get; private set; }

    internal int SpinValue { get; set; }

    public HotKeyStruct[] HotKeysList { get; private set; }

    internal WindowsMouseSettings WindowsMouseSettings { get; set; }

    IRotationEngine rotationEngine;

    internal void Dosmth(HotKeyEnum hotKeyEnum)
    {
        switch (hotKeyEnum)
        {
            case HotKeyEnum.FullRotation:
                rotationEngine.DoFullRotation();
                break;
            case HotKeyEnum.RotationIncrement:
                rotationEngine.AddRotation();
                form1.gameDatauc1.UpdateMainValueHolder();
                break;
            case HotKeyEnum.RotationDecrement:
                rotationEngine.SubRotation();
                form1.gameDatauc1.UpdateMainValueHolder();
                break;

            case HotKeyEnum.RotationScaleIncrement:
                rotationEngine.IncrSpeed();
                break;
            case HotKeyEnum.RotationScaleDecrement:
                rotationEngine.DecrSpeed();
                break;
            case HotKeyEnum.SaveFile:
                throw new NotImplementedException("no");
                //break;
        }
    }
}