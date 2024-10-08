using AdvancedRPC;
using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XMLReader.Helpers
{
    public static class xml
    {
        public static XmlSettings ReadSettings()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml");
            if (!File.Exists(path))
            {

                MessageBox.Show("Missing xml file, please restart..");
                new XDocument(
                    new XElement("config",
                        new XElement("AppConfig",
                            new XComment(" DO NOT CHANGE THESE SETTINGS FOR AVOID ERRORS, OPEN THROUGH THE SETTINGS GUI UNLESS YOU KNOW WHAT YOU ARE DOING! "),
                            new XElement("ClientID", "699283517254795265"),
                            new XElement("LargeImg", "konna"),
                            new XElement("LargeImgText", "Hello World"),
                            new XElement("SmallImg", "slep"),
                            new XElement("SmallImgText", "Online"),
                            new XElement("inLauncherMessage"),
                            new XElement("DeviceDetail", "False"),
                            new XElement("UpdatePresence", "False"),
                            new XElement("PartyEnable", "False"),
                            new XElement("PartySize", 1),
                            new XElement("PartyMax", 5),
                            new XElement("PartyMessage", "Domain Expansion"),
                            new XElement("Button", "False"),
                            new XElement("ButtonText"),
                            new XElement("ButtonLink")
                    ))).Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml"));

                MessageBox.Show("XML file generated. please restart the application", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Environment.Exit(0);
            }

            XmlDocument value = XMLParser.LoadDocument(path);
            string ClientId = XMLParser.FindByTag("ClientID", value)[0];
            string SmallImg = XMLParser.FindByTag("SmallImg", value)[0];
            string SmallImgText = XMLParser.FindByTag("SmallImgText", value)[0];
            string LargeImg = XMLParser.FindByTag("LargeImg", value)[0];
            string LargeImgText = XMLParser.FindByTag("LargeImgText", value)[0];
            string DeviceDetail = XMLParser.FindByTag("DeviceDetail", value)[0];
            string UpdatePresence = XMLParser.FindByTag("UpdatePresence", value)[0];
            string PartyEnable = XMLParser.FindByTag("PartyEnable", value)[0];
            int PartySize = Convert.ToInt32(XMLParser.FindByTag("PartySize", value)[0]);
            int PartyMax = Convert.ToInt32(XMLParser.FindByTag("PartyMax", value)[0]);
            string PartyMessage = XMLParser.FindByTag("PartyMessage", value)[0];
            string Button = XMLParser.FindByTag("Button", value)[0];
            string ButtonText = XMLParser.FindByTag("ButtonText", value)[0];
            string ButtonLink = XMLParser.FindByTag("ButtonLink", value)[0];

            XmlSettings setting = new XmlSettings();
            setting.clientId = ClientId;
            setting.largeImg = LargeImg;
            setting.largeImgText = LargeImgText;
            setting.smallImg = SmallImg;
            setting.smallImgText = SmallImgText;
            setting.deviceDetail = DeviceDetail;
            setting.updatePresence = UpdatePresence;
            setting.partyEnable = PartyEnable;
            setting.partySize = PartySize;
            setting.partyMax = PartyMax;
            setting.partyMessage = PartyMessage;
            setting.button = Button;
            setting.buttonText = ButtonText;
            setting.buttonLink = ButtonLink;
            return setting;
        }

        public static void SaveToXml(XmlSettings settings)
        {
            new XDocument(
                new XElement("config",
                    new XElement("AppConfig",
                        new XComment(" DO NOT CHANGE THESE SETTINGS FOR AVOID ERRORS, OPEN THROUGH THE SETTINGS GUI UNLESS YOU KNOW WHAT YOU ARE DOING! "),
                        new XElement("ClientID", settings.clientId),
                        new XElement("LargeImg", settings.largeImg),
                        new XElement("LargeImgText", settings.largeImgText),
                        new XElement("SmallImg", settings.smallImg),
                        new XElement("SmallImgText", settings.smallImgText),
                        new XElement("DeviceDetail", settings.deviceDetail),
                        new XElement("UpdatePresence", settings.updatePresence),
                        new XElement("PartyEnable", settings.partyEnable),
                        new XElement("PartySize", settings.partySize),
                        new XElement("PartyMax", settings.partyMax),
                        new XElement("PartyMessage", settings.partyMessage),
                        new XElement("Button", settings.button),
                        new XElement("ButtonText", settings.buttonText),
                        new XElement("ButtonLink", settings.buttonLink)
                        )
                    )
                ).Save(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "settings.xml"));
        }
    }
}