using System.Runtime.InteropServices;

namespace SetMouseForGames;

public partial class SimpleAutoClickerUC : UserControl
{
    private int pxDistanceToTravel = 4;

    private CancellationTokenSource? cts;
    private Task? clickTask;

    public SimpleAutoClickerUC()
    {
        InitializeComponent();
        UpdateDistanceLabel();
    }

    private void Start_Click(object sender, EventArgs e)
    {
        if (clickTask is { IsCompleted: false })
            return;

        cts?.Cancel();
        cts = new CancellationTokenSource();

        clickTask = ClickAsync(cts.Token);
    }

    private void Stop_Click(object sender, EventArgs e)
    {
        cts?.Cancel();
    }

    private async Task ClickAsync(CancellationToken token)
    {
        const int taskDelay = 1000;


        while (!token.IsCancellationRequested)
        {
            await Task.Delay(taskDelay, token);
            SingleClick();
        }

    }

    private void SingleClick()
    {
        const uint MOUSEEVENTF_LEFTDOWN = 0x0002;
        const uint MOUSEEVENTF_LEFTUP = 0x0004;

        MouseControlWindowsAPI.INPUT[] inputs = new MouseControlWindowsAPI.INPUT[2];

        inputs[0] = new MouseControlWindowsAPI.INPUT
        {
            type = 0,
            mi = new MouseControlWindowsAPI.MOUSEINPUT
            {
                dwFlags = MOUSEEVENTF_LEFTDOWN
            }
        };

        inputs[1] = new MouseControlWindowsAPI.INPUT
        {
            type = 0,
            mi = new MouseControlWindowsAPI.MOUSEINPUT
            {
                dwFlags = MOUSEEVENTF_LEFTUP
            }
        };

        MouseControlWindowsAPI.SendInput(
            (uint)inputs.Length,
            inputs,
            Marshal.SizeOf(typeof(MouseControlWindowsAPI.INPUT))
        );
    }

    private void PxDistanceIncr_Click(object sender, EventArgs e)
    {
        pxDistanceToTravel++;
        UpdateDistanceLabel();
    }

    private void PxDistanceDecr_Click(object sender, EventArgs e)
    {
        pxDistanceToTravel--;
        UpdateDistanceLabel();
    }

    private void UpdateDistanceLabel()
    {
        const int minDistance = 3;
        const int maxDistance = 10;

        pxDistanceToTravel = Math.Clamp(pxDistanceToTravel, minDistance, maxDistance);

        PxDistanceLabel.Text = $"{pxDistanceToTravel}px";
    }
}


