using AdvancedRPC;
using System;
using System.Threading;
using System.Windows.Forms;

static class Tray
{
    private static Form1 formInstance;

    [STAThread]
    public static void INIT()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.ApplicationExit += new EventHandler(OnApplicationExit);
        RPCProgam.Init();

        MessageBox.Show("Application Is Running in tray", "AdvancedRPC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ShowForm();

        using (NotifyIcon icon = new NotifyIcon())
        {
            icon.Icon = System.Drawing.Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            icon.ContextMenu = new ContextMenu(new MenuItem[] {
                new MenuItem("Options", (s, e) => { ShowForm(); }),
                new MenuItem("Exit", (s, e) => { Environment.Exit(0); }),
            });

            icon.MouseClick += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    ShowForm();
                }
            };

            icon.Visible = true;

            Application.Run();

            icon.Visible = false;
        }
    }

    private static void ShowForm()
    {
        if (formInstance == null || formInstance.IsDisposed)
        {
            formInstance = new Form1();
            formInstance.Show();
        }
        else
        {
            if (formInstance.WindowState == FormWindowState.Minimized)
            {
                formInstance.WindowState = FormWindowState.Normal;
            }
            formInstance.BringToFront();
            formInstance.Show();
        }
    }

    static void OnApplicationExit(object sender, EventArgs e)
    {
        Environment.Exit(0);
    }
}
