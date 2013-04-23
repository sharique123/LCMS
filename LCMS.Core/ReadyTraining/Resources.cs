using System.Collections.Generic;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("resources")]
  public class Resources
  {
    [XmlElement("title")]
    public string Title { get; set; }

    [XmlElement("contact_leadin")]
    public string Contact_leadin { get; set; }

    [XmlElement("docs")]
    public List<ResourcesDocs> Docs { get; set; }

    [XmlElement("contacts")]
    public List<ResourcesContacts> Contacts { get; set; }
  }

  public class ResourcesContacts
  {
    [XmlElement("contact")]
    public List<ResourcesContact> Contact { get; set; }
  }

  public class ResourcesContact
  {
    [XmlElement("title")]
    public List<ResourcesContactsTitle> Title { get; set; }

    [XmlElement("number")]
    public List<ResourcesContactsNumber> Number { get; set; }

    [XmlElement("email")]
    public List<ResourcesContactsEmail> Email { get; set; }
  }

  public class ResourcesContactsEmail
  {
    [XmlText]
    public string Email { get; set; }
  }

  public class ResourcesContactsNumber
  {
    [XmlText]
    public string Number { get; set; }
  }

  public class ResourcesContactsTitle
  {
    [XmlText]
    public string Title { get; set; }
  }

  public class ResourcesDocs
  {
    [XmlElement("doc")]
    public List<Doc> Doc { get; set; }
  }

  
}