using System.Runtime.InteropServices;

namespace SetMouseForGames;

internal class CheckMousePosition
{
    #region Singleton
    private static CheckMousePosition checkMousePosition = null!;
    private static readonly object padlock = new object();


    public static CheckMousePosition CheckMousePositionx
    {
        get
        {
            lock (padlock)
            {
                if (checkMousePosition is null)
                    checkMousePosition = new CheckMousePosition();

                return checkMousePosition;
            }
        }
    }

    CheckMousePosition()
    {
        StartCheckingMousePosition();
    }

    #endregion

    CancellationTokenSource? cts;
    Task? checkMouseTask;

    public event Action MouseMovedEvent;
    public event Action MouseNotMovedForLongTimeEvent;

    Point lastMousePosition;
    internal Point GetLastMousePosition() => lastMousePosition;

    int checkMouseInterval = 1000;
    internal void SetCheckMouseInterval(int interval) => checkMouseInterval = interval;

    DateTime lastMouseMove;
    internal DateTime GetLastMouseMove() => lastMouseMove;
    internal int GetLastMouseMoveIntervalMs() => (int)(DateTime.Now - lastMouseMove).TotalMilliseconds;

    int idleTime = 1000 * 5;
    internal void SetIdleTimeMs(int timeMs) => idleTime = timeMs;

    void StartCheckingMousePosition()
    {
        if (checkMouseTask is { IsCompleted: false })
            return;

        cts?.Cancel();
        cts = new CancellationTokenSource();

        checkMouseTask = CheckMousePositionAsync(cts.Token);
    }

    async Task CheckMousePositionAsync(CancellationToken token)
    {

        while (!token.IsCancellationRequested)
        {

            if (GetLastMouseMoveIntervalMs() > idleTime)
                MouseNotMovedForLongTimeEvent?.Invoke();


            await Task.Delay(checkMouseInterval, token);
            GetCursorPos(out Point mouseNow);

            if (mouseNow != lastMousePosition)
            {
                MouseMovedEvent?.Invoke();
                lastMousePosition = mouseNow;
                lastMouseMove = DateTime.Now;
            }

        }
    }

    [DllImport("user32.dll")]
    public static extern bool GetCursorPos(out Point lpPoint);
}

