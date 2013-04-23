using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LCMS.Core.ReadyTraining
{
  public abstract class Media
  {
    [XmlAttribute("path")]
    public string Path { get; set; }
    [XmlAttribute("auto_hide")]
    public string AutoHide { get; set; }
    [XmlAttribute("auto_play")]
    public string AutoPlay { get; set; }
    
    [XmlAttribute("placement")]
    [JsonConverter(typeof(StringEnumConverter))]
    public MediaPlacement Placement { get; set; }
  }

  public enum MediaPlacement
  {
    Left,
    Right,
    Top,
    Bottom,
    TopLeft,
    TopRight,
    BottomLeft,
    BottomRight,
  }
}