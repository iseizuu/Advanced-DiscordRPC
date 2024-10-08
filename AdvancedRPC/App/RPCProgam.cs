using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using DiscordRPC;
using DiscordRPC.Logging;
using System.Threading;
using System.Windows.Forms;
using System.Management;
using XMLReader.Helpers;
using Button = DiscordRPC.Button;
using XMLReader;

class RPCProgam
{
    [DllImport("user32.dll")]
    static extern IntPtr GetForegroundWindow();
    [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]
    static extern int GetWindowText(IntPtr hWnd, System.Text.StringBuilder lpString, int nMaxCount);
    static DiscordRpcClient client;
    static bool rpcInitialized = false;
    static Timestamps startTime;
    static CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

    public static void Init()
    {
        InitializeDiscordRPC();

        Thread rpcThread = new Thread(DiscordRPCUpdateLoop)
        {
            IsBackground = true
        };
        rpcThread.Start();

        Application.ApplicationExit += (s, e) =>
        {
            cancellationTokenSource.Cancel();
            client.Deinitialize();
        };
    }

    static XmlSettings db = xml.ReadSettings();
    static void InitializeDiscordRPC()
    {
        try
        {
            client = new DiscordRpcClient(db.clientId)
            {
                Logger = new ConsoleLogger() { Level = LogLevel.Warning }
            };

            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Discord Rich Presence is ready!");
                rpcInitialized = true;
            };

            client.Initialize();

            startTime = Timestamps.Now;

            client.SetPresence(new RichPresence()
            {
                Details = "Hello There",
                State = "Idle",
                Timestamps = startTime,
                Assets = new Assets()
                {
                    LargeImageKey = xml.ReadSettings().largeImg,
                    LargeImageText = "Starting...",
                }
            });
        }
        catch (Exception ex){
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    static void DiscordRPCUpdateLoop()
    {
        try
        {
            while (!cancellationTokenSource.Token.IsCancellationRequested)
            {
                if (rpcInitialized)
                {
                    string windowTitle = GetActiveWindowTitle();
                    Console.WriteLine($"Focused window: {windowTitle}");    

                    var (cpuUsage, ramUsage, totalRam) = GetSystemInfo();
                    Console.WriteLine($"CPU Usage: {cpuUsage}%, RAM Usage: {ramUsage}% of {totalRam}GB");

                    UpdateDiscordPresence(windowTitle, cpuUsage, ramUsage, totalRam);
                }

                Thread.Sleep(5000);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Console.WriteLine($"Error in RPC loop: {ex.Message}");
        }
    }

    static void UpdateDiscordPresence(string windowTitle, float cpuUsage, float ramUsage, float totalRam)
    {
        DateTime now = DateTime.Now;
        string deviceDetail = xml.ReadSettings().deviceDetail;
        string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");
            client.SetPresence(new RichPresence()
            {
                Details = xml.ReadSettings().updatePresence == "True" ? "Hello There!" : windowTitle,
                State = xml.ReadSettings().partyEnable == "True" ? xml.ReadSettings().partyMessage : deviceDetail == "False" ? $"CPU: {cpuUsage}%, RAM: {ramUsage}% of {totalRam}GB" : xml.ReadSettings().partyMessage,
                Timestamps = startTime,
                Assets = new Assets()
                {
                    LargeImageKey = xml.ReadSettings().largeImg,
                    LargeImageText = xml.ReadSettings().largeImgText,
                    SmallImageKey = xml.ReadSettings().smallImg,
                    SmallImageText = xml.ReadSettings().smallImgText
                },
                Party = xml.ReadSettings().partyEnable == "True" ? new Party()
                {
                    ID = Secrets.CreateFriendlySecret(new Random()),
                    Size = xml.ReadSettings().partySize,
                    Max = xml.ReadSettings().partyMax,
                    Privacy = Party.PrivacySetting.Public,
                
                } : null,
                Buttons = xml.ReadSettings().button == "True" ? new Button[] { 
                    new Button() 
                    { 
                        Label = string.IsNullOrEmpty(xml.ReadSettings().buttonText) ? formattedDate : xml.ReadSettings().buttonText.Trim(), 
                        Url = string.IsNullOrEmpty(xml.ReadSettings().buttonLink) ? "https://aizuu.my.id" : xml.ReadSettings().buttonLink 
                    } 
                } : null
            });
    }

    static string GetActiveWindowTitle()
    {
        const int nChars = 256;
        System.Text.StringBuilder buff = new System.Text.StringBuilder(nChars);
        IntPtr handle = GetForegroundWindow();

        if (GetWindowText(handle, buff, nChars) > 0)
        {
            return buff.ToString();
        }
        return "On Desktop";
    }

    static (float cpuUsage, float ramUsage, float totalRam) GetSystemInfo()
    {
        float cpuUsage = 0;
        float ramUsage = 0;
        float totalRam = 0;

        PerformanceCounter cpuCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
        cpuUsage = cpuCounter.NextValue();
        Thread.Sleep(1000);
        cpuUsage = cpuCounter.NextValue();
        cpuUsage = (float)Math.Round(cpuUsage, 0);

        PerformanceCounter ramCounter = new PerformanceCounter("Memory", "% Committed Bytes In Use");
        ramUsage = ramCounter.NextValue();
        ramUsage = (float)Math.Round(ramUsage, 0);

        ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
        ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
        ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();

        ulong ramInKB = 0;

        foreach (ManagementObject managementObject in managementObjectCollection)
        {
            ramInKB = (ulong)managementObject["TotalVisibleMemorySize"];
        }

        totalRam = (float)Math.Round((float)ramInKB / (1024 * 1024), 2);

        return (cpuUsage, ramUsage, totalRam);
    }

}
