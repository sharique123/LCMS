using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using LCMS.Core.ReadyTraining;

namespace LCMS.Core
{
  public class XmlManager
  {
    public static XmlDocument GetXmlDocument(string path)
    {
      var doc = new XmlDocument();

      var xmlSettings = new XmlReaderSettings
                          {IgnoreComments = true, IgnoreProcessingInstructions = true, IgnoreWhitespace = true};

      var xmlReader = XmlReader.Create(new StringReader(File.ReadAllText(path)),xmlSettings);

      try
      {
        doc.Load(xmlReader);
        return doc;
      }
      catch (Exception)
      {
        return GetEmptyXmlDoc();
      }
    }


    private static XmlDocument GetEmptyXmlDoc()
    {
      var doc = new XmlDocument();

      var xmlReader = XmlReader.Create(new StringReader(""));
      doc.Load(xmlReader);
      return doc;
    }


    public static string FormatXml(string xml)
    {
      var xd = new XmlDocument();
      xd.Load(xml);

      var sb = new StringBuilder();
      var sw = new StringWriter(sb);


      XmlTextWriter xtw =null;

      try
      {
        xtw = new XmlTextWriter(sw) {Formatting = Formatting.Indented};

        xd.WriteContentTo(xtw);
      }
      catch (Exception)
      {
        
        if (xtw !=null)
        {
          xtw.Close();
        }
      }
      return sb.ToString();
    }

    public static T GetXmlObject<T>(string path)
    {
      XmlDocument xml =
        GetXmlDocument(path);
      
      var serializer = new XmlSerializer(typeof (T));

      var obj = (T) serializer.Deserialize(new StringReader(AddCdata(xml.InnerXml)));

      return obj;
    }

    public static XmlDocument GetXmlFromObject<T>(object obj)
    {
      var xml = new XmlDocument();
      var xns = new XmlSerializerNamespaces();
      var serializer = new XmlSerializer(typeof(T));

      var textWriter = new StringWriterWithEncoding(new StringBuilder(), Encoding.UTF8);

      var xmlWriterSettings = new XmlWriterSettings {Encoding = Encoding.UTF8, Indent = true,CloseOutput = true};
      var xmlWriter = XmlWriter.Create(textWriter, xmlWriterSettings);

      xns.Add(string.Empty,string.Empty);
      serializer.Serialize(xmlWriter, obj,xns);
      xmlWriter.Close();
      xml.LoadXml(textWriter.ToString());
      return xml;
    }


    public static string AddCdata(string xml)
    {
      var xmlString = new StringBuilder();
      xmlString.Append(xml);

      var xmlStringToReplace = XmlManager.GetXmlDocument(string.Format("{0}/XmlToBeReplacedwithCdata.xml", Settings.ApplicationPath));

      var listOfStringToReplace = xmlStringToReplace.SelectNodes("XmlToBeReplacedForJsonList");

      foreach (XmlNode node in listOfStringToReplace)
      {
        for (var i=0; i < node.ChildNodes.Count; i++)
        {
          var nodeText = node.ChildNodes[i].InnerText;
          string findStartString = string.Format("<{0}>", nodeText);
          string findEndString = string.Format("</{0}>", nodeText);
          string replaceStartString = string.Format("<{0}><![CDATA[", nodeText);
          string replaceEndString = string.Format("]]></{0}>", nodeText);
          if (!xmlString.ToString().Contains(replaceStartString))
          {
            xmlString.Replace(findStartString, replaceStartString);
            xmlString.Replace(findEndString, replaceEndString);
          }
          
        }
      }
      return xmlString.ToString();
    }

  }

  public class StringWriterWithEncoding : StringWriter
  {
    readonly Encoding _encoding;

    public StringWriterWithEncoding(StringBuilder builder, Encoding encoding)
      : base(builder) {
      this._encoding = encoding;
    }

    public override Encoding Encoding {
      get { return _encoding; }
    }
  }

  public class Cdata : IXmlSerializable
  {

    private string _text;

    public Cdata() { }

    public Cdata(string text) {
      this._text = text;
    }

    public Cdata(XmlNode text) {
      this._text = text.InnerXml;
    }

    public string Text {
      get { return _text; }
    }

    XmlSchema IXmlSerializable.GetSchema() {
      return null;
    }

    void IXmlSerializable.ReadXml(XmlReader reader) {
      this._text = reader.ReadString();
      reader.Read(); // change in .net 2.0,
      // without this line, you will lose value of all other fields
    }

    void IXmlSerializable.WriteXml(XmlWriter writer) {
      writer.WriteCData(this._text);
    }
    public override string ToString() {
      return this._text;
    }
  }

  [XmlType]
  public class EDocument
  {
    private string _document;

    [XmlAnyElement]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public XmlElement[] DocumentNodes { get; set; }

    [XmlIgnore]
    public string Document {
      get {
        if (this._document == null) {
          var sb = new StringBuilder();
          foreach (var node in this.DocumentNodes) {
            sb.Append(node.OuterXml);
          }

          this._document = "<![CDATA[" + sb.ToString() + "]]>";
        }

        return this._document;
      }
    }
  }

}
