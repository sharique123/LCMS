using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LCMS.Core.ReadyTraining
{
  public class Audio:Media
  {
    [XmlAttribute("type")]
    [JsonConverter(typeof(StringEnumConverter))]
    public AudioType Type { get; set; }
  }

  public enum AudioType
  {
    mp3mini,
    mp3full,
  }
}