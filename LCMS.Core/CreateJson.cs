using System;
using System.Text;
using System.Xml;

namespace LCMS.Core
{
  public class CreateJson
  {
    public static String ConvertXmlToJson(string path, string fileName, bool isMinified)
    {
      var xml = XmlManager.GetXmlDocument(string.Format("{0}/{1}", path, fileName)).InnerXml;

      if (!fileName.Contains("config_") || !fileName.Contains("config_"))
        xml = UpdatedConfigValues(xml);
      
      // this should be last because this adds payload
      xml = "<payload>" + StripXml(xml) + "</payload>";
 
      return xml;
    }

    private static string UpdatedConfigValues(string xml)
    {
      var xmlString = new StringBuilder();
      xmlString.Append(xml);

      var xmlStringToReplace = Settings.ConfigXml;

      var node = xmlStringToReplace.SelectSingleNode("config/company_name");
      xmlString.Replace("company_name", node.InnerText);

      node = xmlStringToReplace.SelectSingleNode("config/company_attribute");
      xmlString.Replace("company_attribute", node.InnerText);

      node = xmlStringToReplace.SelectSingleNode("config/employee_attribute");
      xmlString.Replace("employee_attribute", node.InnerText);

      return xmlString.ToString();
    }


    private static String StripXml(string xml)
    {
      
      var xmlString = new StringBuilder();
      xmlString.Append(xml);

      var xmlStringToReplace = XmlManager.GetXmlDocument(string.Format("{0}/XmlToBeReplacedForJson.xml", Settings.ApplicationPath));

      var listOfStringToReplace = xmlStringToReplace.SelectNodes("XmlToBeReplacedForJsonList");

      foreach (XmlNode node in listOfStringToReplace)
      {
        for (int i = 0; i < node.ChildNodes.Count - 1; i++)
        {
          string findString = node.ChildNodes.Item(i).ChildNodes.Item(0).InnerText;
          string replaceString = node.ChildNodes.Item(i).ChildNodes.Item(1).InnerText;
          xmlString.Replace(findString, replaceString);
        }
      }

      return xmlString.ToString();

    }
  }
}
