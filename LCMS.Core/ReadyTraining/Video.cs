using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  public class Video : Media
  {
    [XmlAttribute("width")]
    public int Width { get; set; }

    [XmlAttribute("height")]
    public int Height { get; set; }

    [XmlAttribute("screenx")]
    public int Screenx { get; set; }

    [XmlAttribute("screeny")]
    public int Screeny { get; set; }
  }
}