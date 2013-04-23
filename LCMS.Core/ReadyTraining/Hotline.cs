using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
   [XmlRoot("hotline")]
  public class Hotline
  {
    [XmlElement("title")]
    public string Title{ get; set; }
    [XmlElement("header")]
    public string Header { get; set; }
    [XmlElement("lead_paragraph")]
    public string LeadParagraph { get; set; }

    [XmlElement("additional_info", typeof(Cdata))]
    public Cdata AdditionalInfo { get; set; }

    [XmlElement("contacts")]
    public List<HotlineContacts> Contacts { get; set; }
  }

  public class HotlineContacts
  {
    [XmlElement("online_header")]
    public string OnlineHeader { get; set; }

    [XmlElement("online_link")]
    public List<HotlineContactsOnlineLink> OnlineLink { get; set; }

    [XmlElement("online_details")]
    public string OnlineDetails { get; set; }

    [XmlElement("phone_header")]
    public string PhoneHeader { get; set; }

    [XmlElement("phone_number")]
    public List<HotlineContactsPhoneNumber> PhoneNumber { get; set; }

    [XmlElement("phone_details")]
    public string PhoneDetails { get; set; }
  }

  
  public class HotlineContactsOnlineLink
  {
    [XmlText]
    public string LinkText { get; set; }

    [XmlAttribute("url")]
    public string Url { get; set; }

    [XmlAttribute("color")]
    public string Color { get; set; }
  }

  public class HotlineContactsPhoneNumber
  {
    [XmlText]
    public string PhoneText { get; set; }

    [XmlAttribute("color")]
    public string Color { get; set; }
  }
}
