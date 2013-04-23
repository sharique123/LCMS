using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("config")]
  public class Config
  {
    [XmlAttribute("languagecode")]
    public string LanguageCode { get; set; }

    [XmlElement("company_name")]
    public string CompanyName { get; set; }

    [XmlElement("company_attribute")]
    public string CompanyAttribute { get; set; }

    [XmlElement("company_capital_attribute")]
    public string CompanyCapitalAttribute { get; set; }

    [XmlElement("employee_attribute")]
    public string EmployeeAttribute { get; set; }

    [XmlElement("employee_capital_attribute")]
    public string EmployeeCapitalAttribute { get; set; }

    [XmlElement("color1")]
    public string Color { get; set; }

    [XmlElement("copyright")]
    public string Copyright { get; set; }

    [XmlElement("fontsize")]
    public int FontSize { get; set; }

    [XmlElement("fontscale")]
    public string FontScale { get; set; }

    [XmlElement("screen_timer")]
    public ConfigScreenTimer ScreeenTimer { get; set; }

  }

  public class ConfigScreenTimer
  {
    [XmlElement("default_duration")]
    public int DefaultDuration { get; set; }
  }
}