using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("certificate")]
  public class Certificate
  {
    private string _languageCode;
    private string _path;

    public Certificate()
    {
    }

    public Certificate(string path, string languageCode)
    {
      _path = path;
      _languageCode = languageCode;
    }

    [XmlElement("title")]
    public string Title { get; set; }

    [XmlElement("heading")]
    public string Heading { get; set; }

    [XmlElement("coursecompleted")]
    public string CourseCompleted { get; set; }

    [XmlElement("datename")]
    public string DateName { get; set; }

    [XmlElement("signaturename")]
    public string SignatureName { get; set; }

    [XmlElement("signaturevalue")]
    public string SignatureValue { get; set; }

    [XmlElement("background", typeof(Cdata))]
    public Cdata Background { get; set; }
  }
}