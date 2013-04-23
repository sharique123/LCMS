using System.Collections.Generic;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  public class BulletList
  {
    [XmlAttribute("delay")]
    public int Delay { get; set; }

    [XmlAttribute("color")]
    public string Color { get; set; }

    [XmlElement("bullet")]
    public List<Bullet> Bullets { get; set; }
  }

  public class Bullet
  {
    [XmlAttribute("target")]
    public string Target { get; set; }

    [XmlText]
    public string Text { get; set; }
  }
}