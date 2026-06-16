namespace SetMouseForGames;

public partial class SimpleAutoclickerUC : UserControl
{
    bool autoclick;

    int pxDistanceToTravel = 4;

    public SimpleAutoclickerUC()
    {
        InitializeComponent();
        UpdateDistanceLabel();
    }

    private async void Start_Click(object sender, EventArgs e)
    {
        Click();
    }

    private void Stop_Click(object sender, EventArgs e)
    {
        autoclick = false;
    }

    private async void Click()
    {
        autoclick = true;


        int taskDelay = 125;

        while (autoclick)
        {
            await Task.Delay(taskDelay);
            MouseSpinClass.DoMove(pxDistanceToTravel, 0);
            await Task.Delay(taskDelay);
            MouseSpinClass.DoMove(0, -pxDistanceToTravel);
            await Task.Delay(taskDelay);
            MouseSpinClass.DoMove(-pxDistanceToTravel, 0);
            await Task.Delay(taskDelay);
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
