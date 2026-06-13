using System.Runtime.InteropServices;

namespace SetMouseForGames;

internal class WindowsAPI
{

    [DllImport("user32.dll")]
    internal static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

    [DllImport("user32.dll")]
    internal static extern bool UnregisterHotKey(IntPtr hWnd, int id);

    [DllImport("user32.dll")]
    internal static extern bool SystemParametersInfo(uint uiAction, uint uiParam, ref int pvParam, uint fWinIni);

    [DllImport("user32.dll")]
    internal static extern bool SystemParametersInfo(uint uiAction, uint uiParam, int[] pvParam, uint fWinIni);

    [DllImport("User32.dll")]
    internal static extern Boolean SystemParametersInfo(UInt32 uiAction, UInt32 uiParam, UInt32 pvParam, UInt32 fWinIni);

    internal enum Windows_SPIs
    {
        SPI_GETMOUSE = 0x0003,
        SPI_GETWHEELSCROLLLINES = 0x0068,
        SPI_GETMOUSESPEED = 0x0070,
        SPI_SETMOUSESPEED = 0x0071,
    }
}


