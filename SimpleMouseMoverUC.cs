namespace SetMouseForGames;

public partial class SimpleMouseMoverUC : UserControl
{
    bool autoclick;

    int pxDistanceToTravel = 4;

    private CancellationTokenSource? cts;
    private Task? clickTask;

    public SimpleMouseMoverUC()
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
        const int taskDelay = 125;

        while (!token.IsCancellationRequested)
        {
            await Task.Delay(taskDelay, token);
            MouseSpinClass.DoMove(pxDistanceToTravel, 0);
            await Task.Delay(taskDelay, token);
            MouseSpinClass.DoMove(0, -pxDistanceToTravel);
            await Task.Delay(taskDelay, token);
            MouseSpinClass.DoMove(-pxDistanceToTravel, 0);
            await Task.Delay(taskDelay, token);
            MouseSpinClass.DoMove(0, pxDistanceToTravel);
        }

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

    void UpdateDistanceLabel()
    {
        const int minDistance = 3;
        const int maxDistance = 10;

        pxDistanceToTravel = Math.Clamp(pxDistanceToTravel, minDistance, maxDistance);

        PxDistanceLabel.Text = $"{pxDistanceToTravel.ToString()}px";
    }
}
