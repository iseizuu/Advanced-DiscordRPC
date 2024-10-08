# Advanced Discord RPC

Advanced Discord RPC is a custom-built Discord Rich Presence (RPC) client that allows you to manage and display your rich presence with advanced features such as custom images, party settings, and buttons on Discord. 

## Features

- Customizable Client ID
- Custom Large and Small Images with Text
- Party Settings
- Custom Buttons with Text and Links
- Device Details (show: Ram, Cpu) and Presence Updates
- Plug And Play

## Prerequisites

- [.NET Framework](https://dotnet.microsoft.com/id-id/download/dotnet-framework/net472) (version 4.7.2 or higher recommended)
- Discord account and a registered application with [Discord Developer Portal](https://discord.com/developers/applications)

## Installation

1. Download the release from the repository.
2. Extract the files to a directory of your choice.
3. Run the application.

You need to have knowledge about Discord Application, if you dont have please make one in [Discord Developer Portal](https://discord.com/developers/applications)

## Usage

1. Upon launching the application, you'll see a notification that the presence is running.
2. The application runs in the system tray. You can open the settings window by right-clicking on the tray icon and selecting **Options** or by left-clicking the tray icon.
3. Configure your rich presence using the available fields:
   - **Client ID**: Set your Discord application's Client ID.
   - **Large and Small Images**: Customize the large and small images shown in your rich presence.
   - **Party Settings**: Enable or disable party display, set party size, max size, and message.
   - **Buttons**: Enable a button with a custom link that users can click from your rich presence.
4. Save your settings, and the app will update your presence on Discord.

## Gui

<a href="https://ibb.co.com/XkzSVyJ"><img src="https://i.ibb.co.com/5x5B2Yc/rpc-preview.png" alt="rpc-preview" border="0" /></a> <a href="https://imgbb.com/"><img src="https://i.ibb.co.com/KLydj4F/rpc-preview-1.png" alt="rpc-preview-1" border="0" /></a>

## Contributing
Feel free to fork this repository and submit pull requests for improvements or additional features. Please make sure to follow best practices for C# development.

## Troubleshooting
  -  Presence not updating: Ensure that your Client ID is correct and Discord is running.
  -  Weird Font: Please open the installation path, and open font folder and install.
