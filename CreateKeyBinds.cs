namespace SetMouseForGames;

internal class CreateKeyBinds
{

    internal enum ModKeys
    {
        LAlt = 0x0001,
        LCtrl = 0x0002,
        LShift = 0x0004,
        LWin = 0x0008,
    }


    internal static HotKeyStruct[] CreateKeyBindsX()
    {

        HotKeyStruct[] hotKeyStructsList = new HotKeyStruct[0];

        AddKeybind(HotKeyEnum.FullRotation, ModKeys.LWin, Keys.F2);

        AddKeybind(HotKeyEnum.RotationDecrement, ModKeys.LWin, Keys.F6);
        AddKeybind(HotKeyEnum.RotationIncrement, ModKeys.LWin, Keys.F7);

        AddKeybind(HotKeyEnum.RotationScaleDecrement, ModKeys.LWin, Keys.OemOpenBrackets);
        AddKeybind(HotKeyEnum.RotationScaleIncrement, ModKeys.LWin, Keys.OemCloseBrackets);

        AddKeybind(HotKeyEnum.SaveFile, ModKeys.LWin, Keys.F10);

        return hotKeyStructsList.ToArray();


        void AddKeybind(HotKeyEnum id, ModKeys _modKeyID, Keys _keyId)
        {
            if ((int)id >= hotKeyStructsList.Length - 1)
                Array.Resize(ref hotKeyStructsList, (int)id + 1);
            hotKeyStructsList[(int)id] = new HotKeyStruct(_modKeyID, _keyId);
        }
    }
}
