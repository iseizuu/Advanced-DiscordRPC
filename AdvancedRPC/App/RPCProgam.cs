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
    static string currentClientId;
    static readonly object clientLock = new object();

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
            DeinitPresence();
        };
    }

    static void DeinitPresence()
    {
        lock (clientLock)
        {
            if (client != null && rpcInitialized)
            {
                client.Deinitialize();
                client.Dispose();
                client = null;
                rpcInitialized = false;
            }
        }
    }

    static void InitializeDiscordRPC()
    {
        try
        {
            var settings = xml.ReadSettings();
            currentClientId = settings.clientId;

            lock (clientLock)
            {
                client = new DiscordRpcClient(currentClientId)
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

                UpdateInitialPresence();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to initialize Discord RPC: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    static void UpdateInitialPresence()
    {
        var settings = xml.ReadSettings();
        client?.SetPresence(new RichPresence()
        {
            Details = "Hello There",
            State = "Idle",
            Timestamps = startTime,
            Assets = new Assets()
            {
                LargeImageKey = settings.largeImg,
                LargeImageText = "Starting...",
            }
        });
    }

    static void DiscordRPCUpdateLoop()
    {
        while (!cancellationTokenSource.Token.IsCancellationRequested)
        {
            try
            {
                var settings = xml.ReadSettings();

                if (currentClientId != settings.clientId)
                {
                    Console.WriteLine("Client ID changed, reinitializing...");
                    DeinitPresence();
                    InitializeDiscordRPC();
                }

                if (rpcInitialized)
                {
                    string windowTitle = GetActiveWindowTitle();
                    var (cpuUsage, ramUsage, totalRam) = GetSystemInfo();
                    UpdateDiscordPresence(windowTitle, cpuUsage, ramUsage, totalRam);
                }

                Thread.Sleep(5000);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in RPC loop: {ex.Message}");
                Thread.Sleep(10000);
            }
        }
    }

    static void UpdateDiscordPresence(string windowTitle, float cpuUsage, float ramUsage, float totalRam)
    {
        if (!rpcInitialized || client == null) return;
        try
        {
            var settings = xml.ReadSettings();
            DateTime now = DateTime.Now;
            string deviceDetail = settings.deviceDetail;
            string formattedDate = now.ToString("yyyy-MM-dd HH:mm:ss");

            client.SetPresence(new RichPresence()
            {
                Details = settings.updatePresence == "True" ? "Hello There!" : windowTitle.Length > 128 ? windowTitle.Substring(0, 125) + "..." : windowTitle,
                State = settings.partyEnable == "True" ?
                settings.partyMessage :
                    deviceDetail == "False" ? $"CPU: {cpuUsage}%, RAM: {ramUsage}% of {totalRam}GB" :
                    settings.partyMessage,
                Timestamps = startTime,
                Assets = new Assets()
                {
                    LargeImageKey = settings.largeImg,
                    LargeImageText = settings.largeImgText,
                    SmallImageKey = settings.smallImg,
                    SmallImageText = settings.smallImgText
                },
                Party = settings.partyEnable == "True" ? new Party()
                {
                    ID = Secrets.CreateFriendlySecret(new Random()),
                    Size = settings.partySize,
                    Max = settings.partyMax,
                    Privacy = Party.PrivacySetting.Public,
                } : null,
                Buttons = settings.button == "True" ? new Button[] {
                    new Button()
                    {
                        Label = string.IsNullOrEmpty(settings.buttonText) ? xml.ReadSettings().partyMessage : settings.buttonText.Trim(),
                        Url = string.IsNullOrEmpty(settings.buttonLink) ? "https://aizuu.my.id" : settings.buttonLink
                    },
                    new Button()
                    {
                        Label = string.IsNullOrEmpty(settings.buttonText1) ? formattedDate : settings.buttonText1.Trim(),
                        Url = string.IsNullOrEmpty(settings.buttonLink1) ? "https://github.com/iseizuu/" : settings.buttonLink1
                    }
                } : null
            });
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error updating presence: {ex.Message}");
        }
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
