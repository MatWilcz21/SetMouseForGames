namespace SetMouseForGames;


public enum HotKeyEnum
{

    FullRotation,
    RotationIncrement,
    RotationDecrement,
    RotationScaleIncrement,
    RotationScaleDecrement,
    SaveFile,

}

internal record struct HotKeyStruct
{

    internal HotKeyStruct(CreateKeyBinds.ModKeys _modKeyID, Keys _keyId)
    {
        ModKeyID = (uint)_modKeyID;
        KeyID = (uint)_keyId;
    }

    internal uint ModKeyID { get; private set; }
    internal uint KeyID { get; private set; }
}
