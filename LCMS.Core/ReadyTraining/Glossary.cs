using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("glossary")]
  public class Glossary
  {
    [XmlElement("term")]
    public List<GlossaryTerm> Term { get; set; } 
  }

  public class GlossaryTerm
  {
    [XmlAttribute("name")]
    public string Name { get; set; }
    [XmlText]
    public string GlossaryText { get; set; }
  }
}
