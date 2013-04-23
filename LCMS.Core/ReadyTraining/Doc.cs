using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  public class Doc
  {
    [XmlText]
    public string Name { get; set; }

    [XmlAttribute("path")]
    public string Path { get; set; }

    [XmlAttribute("type")]
    public string Type { get; set; }
  }
}