namespace SetMouseForGames;

public partial class SimpleMouseMoverUC : UserControl
{

    int pxDistanceToTravel = 4;

    CancellationTokenSource? cts;
    Task? moveTask;

    public SimpleMouseMoverUC()
    {
        InitializeComponent();
        UpdateDistanceLabel();
    }

    private void Start_Move(object sender, EventArgs e)
    {
        if (moveTask is { IsCompleted: false })
            return;

        cts?.Cancel();
        cts = new CancellationTokenSource();

        moveTask = MoveAsync(cts.Token);
    }

    private void Stop_Click(object sender, EventArgs e)
    {
        cts?.Cancel();
    }

    private async Task MoveAsync(CancellationToken token)
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
