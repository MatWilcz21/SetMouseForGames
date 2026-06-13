using System.Runtime.InteropServices;

namespace SetMouseForGames
{
    internal class MouseSpinClass
    {

        internal static void DoSpin(int spinValue)
        {

            MouseInputLowLevel.DoSpinLowLevel(spinValue);
            Thread.Sleep(500);
            MouseInputLowLevel.DoSpinLowLevel(-spinValue);
        }
    }

    public class MouseInputLowLevel
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint SendInput(uint nInputs, INPUT[] pInputs, int cbSize);

        const uint INPUT_MOUSE = 0;
        const uint MOUSEEVENTF_MOVE = 0x0001;

        [StructLayout(LayoutKind.Sequential)]
        record struct INPUT
        {
            public uint type;
            public MOUSEINPUT mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        record struct MOUSEINPUT
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        public static void DoSpinLowLevel(int spinValueLow)
        {
            INPUT input = new INPUT();

            input.type = INPUT_MOUSE;
            input.mi.dx = spinValueLow;
            input.mi.dy = 0;
            input.mi.dwFlags = MOUSEEVENTF_MOVE;

            SendInput(1, new INPUT[] { input }, Marshal.SizeOf(typeof(INPUT)));
        }
    }
}
