namespace SetMouseForGames;

internal record class WindowsMouseSettings
{
    internal int WindowsSettingsMouseSpeed { get; set; }
    internal bool IsWindowsEnhancePointerPrecisionOn { get; set; }
    internal int WindowsScrollSpeed { get; set; }

    internal int MouseDriverDPI { get; set; }

    Form1 form1;

    internal WindowsMouseSettings(Form1 _form1)
    {
        form1 = _form1;

        //SetMouse();
        UpdateMouseInfo();
    }

    internal void UpdateMouseInfo()
    {
        WindowsSettingsMouseSpeed = GetMouseDescription.GetWindowsSettingsMouseSpeed();

        IsWindowsEnhancePointerPrecisionOn = GetMouseDescription.GetIsEnhancePointerPrecisionOn();

        WindowsScrollSpeed = GetMouseDescription.GetScrollSpeed();

    }

    internal void SetMouse()
    {
        SetMouseClass.SetMouseSpeed(10);
    }

    internal void GetMouseDPI(string dpiString)
    {
        if (string.IsNullOrWhiteSpace(dpiString)) return;
        if (!int.TryParse(dpiString, out int dpi)) return;

        SetMouseDriverDPI(dpi);
    }

    internal void SetMouseDriverDPI(int dpi)
    {
        MouseDriverDPI = dpi;
        //form1.UpdateMouseInfoLabel();
    }

    internal void DebugPrintMouseSettings()
    {

        string messageToPrint = string.Concat($"Mouse speed: {WindowsSettingsMouseSpeed.ToString()}/20\n",
            $"Enhanced precision: {IsWindowsEnhancePointerPrecisionOn.ToString()}\n",
            $"Scroll speed: {WindowsScrollSpeed}lines");

        MessageBox.Show(messageToPrint, "Mouse params");
    }
}

internal class GetMouseDescription
{
    internal static int GetWindowsSettingsMouseSpeed()
    {
        int speed = 0;
        WindowsAPI.SystemParametersInfo((int)WindowsAPI.Windows_SPIs.SPI_GETMOUSESPEED, 0, ref speed, 0);
        return speed;
    }

    internal static bool GetIsEnhancePointerPrecisionOn()
    {
        int[] mouseParams = new int[3];
        WindowsAPI.SystemParametersInfo((int)WindowsAPI.Windows_SPIs.SPI_GETMOUSE, 0, mouseParams, 0);

        if (mouseParams[0] == 0) return false;
        return true;
    }

    internal static int GetScrollSpeed()
    {

        int lines = 0;
        WindowsAPI.SystemParametersInfo((int)WindowsAPI.Windows_SPIs.SPI_GETWHEELSCROLLLINES, 0, ref lines, 0);

        return lines;
    }

}

internal class SetMouseClass
{
    internal static void SetMouseSpeed(int speed)
    {
        WindowsAPI.SystemParametersInfo((int)WindowsAPI.Windows_SPIs.SPI_SETMOUSESPEED, 0, (uint)speed, 0);
    }
}


