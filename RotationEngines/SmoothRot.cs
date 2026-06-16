using System.Diagnostics;
using System.Runtime.InteropServices;

namespace SetMouseForGames;

internal class SmoothRot
{
    private const int WH_KEYBOARD_LL = 13;
    private const int WM_KEYDOWN = 0x0100;
    private const int WM_KEYUP = 0x0101;

    private static IntPtr hook = IntPtr.Zero;
    private static LowLevelKeyboardProc proc = HookCallback;

    private static bool lwinDown = false;
    private static bool f8Down = false;
    private static bool f9Down = false;

    private const int VK_LWIN = 0x5B;
    private const int VK_RWIN = 0x5C;
    private const int VK_F9 = 0x78;
    private const int VK_F8 = 0x77;

    public SmoothRot()
    {
        hook = SetHook(proc);
    }

    private static IntPtr SetHook(LowLevelKeyboardProc proc)
    {
        using (Process curProcess = Process.GetCurrentProcess())
        using (ProcessModule curModule = curProcess.MainModule)
        {
            return SetWindowsHookEx(
                WH_KEYBOARD_LL,
                proc,
                GetModuleHandle(curModule.ModuleName),
                0);
        }
    }

    private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
    {
        if (nCode >= 0)
        {
            KBDLLHOOKSTRUCT hookStruct = Marshal.PtrToStructure<KBDLLHOOKSTRUCT>(lParam);
            int vkCode = (int)hookStruct.vkCode;

            if (wParam == (IntPtr)WM_KEYDOWN)
            {
                if (vkCode == VK_LWIN || vkCode == VK_RWIN)
                    lwinDown = true;

                if (vkCode == VK_F8)
                    f8Down = true;

                if (vkCode == VK_F9)
                    f9Down = true;

                if (lwinDown && f8Down)
                    MouseSpinClass.DoMove(-5);

                if (lwinDown && f9Down)
                    MouseSpinClass.DoMove(5);
            }

            if (wParam == (IntPtr)WM_KEYUP)
            {
                if (vkCode == VK_LWIN || vkCode == VK_RWIN)
                    lwinDown = false;

                if (vkCode == VK_F8)
                    f8Down = false;

                if (vkCode == VK_F9)
                    f9Down = false;
            }
        }

        return CallNextHookEx(hook, nCode, wParam, lParam);
    }

    private struct KBDLLHOOKSTRUCT
    {
        public uint vkCode;
        public uint scanCode;
        public uint flags;
        public uint time;
        public IntPtr dwExtraInfo;
    }

    private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("user32.dll")]
    private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

    [DllImport("user32.dll")]
    private static extern bool UnhookWindowsHookEx(IntPtr hhk);

    [DllImport("user32.dll")]
    private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

    [DllImport("kernel32.dll")]
    private static extern IntPtr GetModuleHandle(string lpModuleName);
}