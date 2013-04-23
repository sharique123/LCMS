using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace LCMS.Core
{
  public class Settings
  {
    public static string ApplicationPath { get; set; }
    public static string CoursePath { get; set; }
    public static string ModulePath { get; set; }
    public static string LanguageSelected { get; set; }
    public static XmlDocument CourseXml { get; set; }
    public static XmlDocument ConfigXml { get; set; }
    public static XmlDocument ResourceXml { get; set; }
    public static XmlDocument HotlineXml { get; set; }
    public static XmlDocument GlossaryXml { get; set; }
    public static XmlDocument ExamXml { get; set; }
    public static XmlDocument CertificateXml { get; set; }  
  }
 }

