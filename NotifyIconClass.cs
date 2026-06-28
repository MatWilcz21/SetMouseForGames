namespace SetMouseForGames;

internal class NotifyIconClass
{

    internal NotifyIconClass(Form1 form1)
    {
        ///

        var menu = new ContextMenuStrip();

        var showItem = new ToolStripMenuItem("Pokaż");
        showItem.Click += (s, e) => form1.NotifyIcon1_DoubleClick();

        /*var hideItem = new ToolStripMenuItem("Ukryj");
        hideItem.Click += (s, e) => HideWindow();

        var exitItem = new ToolStripMenuItem("Zamknij");
        exitItem.Click += (s, e) => ExitApp();*/

        menu.Items.Add(showItem);
        //menu.Items.Add(hideItem);
        menu.Items.Add(new ToolStripSeparator());
        //menu.Items.Add(exitItem);

        form1.notifyIcon1.ContextMenuStrip = menu;
        ///
    }


}
