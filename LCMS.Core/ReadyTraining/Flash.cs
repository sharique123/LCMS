using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  public class Flash
  {
    [XmlAttribute("path")]
    public string Path { get; set; }

    [XmlAttribute("playbar")]
    public bool Playbar { get; set; }

    [XmlAttribute("paramters")]
    public string Paramters { get; set; }
  }
}