using System.Collections.Generic;
using System.IO;
using System.Xml;
namespace XMLReader
{
    public static class XMLParser
    {

        public static XmlDocument LoadDocument(string path)
        {
            if (!File.Exists(path))
            {
                throw new FileNotFoundException("XML Document wasn't found at path!");
            }
            XmlDocument d = new XmlDocument();
            d.Load(path);
            return d;
        }

        public static string[] FindByTag(string NodeName, XmlDocument document)
        {
            XmlNodeList tags = document.GetElementsByTagName(@NodeName);
            if (tags.Count < 1)
            {
                return null;
            }
            else
            {
                List<string> l = new List<string>();

                foreach (XmlNode n in tags)
                {
                    l.Add(n.InnerText);
                }

                string[] f = l.ToArray();
                l.Clear();
                return f;
            }
        }
    }

    public struct XmlSettings
    {
        public string clientId { get; set; }
        public string largeImg { get; set; }
        public string largeImgText { get; set; }
        public string smallImg { get; set; }
        public string smallImgText { get; set; }
        public string deviceDetail { get; set; }
        public string updatePresence { get; set; }
        public string partyEnable { get; set; }
        public int partySize { get; set; }
        public int partyMax { get; set; }
        public string partyMessage { get; set; }
        public string button { get; set; }
        public string buttonText { get; set; }
        public string buttonLink { get; set; }
    }
}