using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;


namespace Accounts.UI
{
    public static class XmlConfiguration
    {
        public static string[] ReadXmlTerminalsConfiguration()
        {
            string path = Application.StartupPath + "\\Configuration.xml";
            string[] list = new string[2];
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Configuration/TerminalConfiguration");
            foreach (XmlNode node in nodeList)
            {
                list[0] = node.SelectSingleNode("TerminalNumber").InnerText;
                list[1] = node.SelectSingleNode("TerminalName").InnerText;
            }
            return list;
        }
        public static string[] ReadXmlTaxConfiguration()
        {
            string path = Application.StartupPath + "\\Configuration.xml";
            string[] list = new string[2];
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            XmlNodeList nodeList = xmlDoc.DocumentElement.SelectNodes("/Configuration/TaxConfiguration");
            foreach (XmlNode node in nodeList)
            {
                list[0] = node.SelectSingleNode("TaxName").InnerText;
                list[1] = node.SelectSingleNode("TaxRate").InnerText;
            }
            return list;
        }
    }
}
