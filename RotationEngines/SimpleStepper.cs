namespace SetMouseForGames;

internal class SimpleStepper : IRotationEngine
{

    MainLogic mainLogic;

    internal SimpleStepper(MainLogic _mainLogic) { mainLogic = _mainLogic; }

    int SpinValueChangeScale = 64;

    int change = 2;
    public void DoFullRotation()
    {
        MouseSpinClass.DoSpin(mainLogic.SpinValue);
        Thread.Sleep(300);
    }

    public void AddRotation()
    {
        mainLogic.SpinValue += SpinValueChangeScale;
        DoFullRotation();
    }

    public void SubRotation()
    {
        mainLogic.SpinValue -= SpinValueChangeScale;
        DoFullRotation();
    }
    public void DecrSpeed()
    {
        SpinValueChangeScale /= change;
    }

    public void IncrSpeed()
    {
        SpinValueChangeScale *= change;
    }

}

