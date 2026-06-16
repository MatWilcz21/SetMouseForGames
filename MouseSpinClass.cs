using System.Runtime.InteropServices;

namespace SetMouseForGames
{
    internal class MouseSpinClass
    {

        internal static void DoSpin(int spinValue)
        {

            MouseInputLowLevel.DoSpinLowLevel(spinValue, 0);
            Thread.Sleep(500);
            MouseInputLowLevel.DoSpinLowLevel(-spinValue, 0);
        }

        internal static void DoMove(int spinValueX, int spinValueY)
        {
            MouseInputLowLevel.DoSpinLowLevel(spinValueX, spinValueY);
        }
    }

    public class MouseInputLowLevel
    {

        const uint INPUT_MOUSE = 0;
        const uint MOUSEEVENTF_MOVE = 0x0001;

        public static void DoSpinLowLevel(int spinValueLowX, int spinValueLowY)
        {
            WindowsAPI.INPUT input = new WindowsAPI.INPUT();

            input.type = INPUT_MOUSE;
            input.mi.dx = spinValueLowX;
            input.mi.dy = -spinValueLowY;
            input.mi.dwFlags = MOUSEEVENTF_MOVE;

            WindowsAPI.SendInput(1, new WindowsAPI.INPUT[] { input }, Marshal.SizeOf(typeof(WindowsAPI.INPUT)));
        }
    }
}
