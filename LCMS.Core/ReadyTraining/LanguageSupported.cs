using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LCMS.Core.ReadyTraining
{
  public class LanguageSupported
  {
    public LanguageSupported(String path)
    {
      Path = path;
    }

    public List<Language> Languages
    {
      get { return GetLanguageList(); }
    }

    [JsonIgnore]
    public String Path { get; set; }

    public List<Language> GetLanguageList()
    {
      var xml = XmlManager.GetXmlDocument(string.Format("{0}/{1}", Path, "Languages.xml"));

      var languageNode = xml.SelectNodes("languages");

      var languageList = new List<Language>();

      foreach (XmlNode node in languageNode)
      {
        for (int i = 0; i < node.ChildNodes.Count - 1; i++)
        {
          var language = new Language();
          language.Name = node.ChildNodes.Item(i).InnerText;
          language.Code = node.ChildNodes.Item(i).Attributes.Item(0).Value;
          language.FontFile = node.ChildNodes.Item(i).Attributes.Item(2).Value;
          language.CharType =
            (CharacterDirection)
            Enum.Parse(typeof (CharacterDirection), node.ChildNodes.Item(i).Attributes.Item(1).Value);
          languageList.Add(language);
        }
      }
      return languageList;
    }
  }



  public class Language
  {
    [XmlAttribute]
    public String Name { get; set; }
    public String Code { get; set; }

    [JsonConverter(typeof (StringEnumConverter))]
    public CharacterDirection CharType { get; set; }
    public String FontFile { get; set; }
  }


  public enum CharacterDirection
  {
    LTR,
    RTL
  }
}