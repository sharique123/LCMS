using System.Collections.Generic;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("course")]
  public class Course
  {
    [XmlAttribute("baseurl")]
    public string Baseurl { get; set; }

    [XmlAttribute("module_dir")]
    public string ModuleDir { get; set; }

    [XmlAttribute("scorm")]
    public string Scorm { get; set; }

    [XmlAttribute("company_name")]
    public string CompanyName { get; set; }

    [XmlAttribute("color1")]
    public string Color { get; set; }

    [XmlElement("module")]
    public List<Module> Module { get; set; }

    //  public Course GetCourse(string path,string languageCode)
    //  {
    //    var course = new Course();
    //    var xml = XmlManager.GetXmlDocument(string.Format("{0}/{1}{2}{3}", path, "Course_",languageCode,".xml"));

    //    var courseNode = xml.SelectNodes("course");
    //    var moduleList = new List<Module>();
    //    foreach (XmlNode node in courseNode)
    //    {
    //      course.Baseurl=node.Attributes.Item(0).Value;
    //      course.Module_dir=node.Attributes.Item(1).Value;
    //      course.Scorm=node.Attributes.Item(2).Value;
    //      course.Company_name=node.Attributes.Item(3).Value;
    //      course.Color1=node.Attributes.Item(4).Value;
    //      for (int i = 0; i < node.ChildNodes.Count - 1; i++)
    //      {
    //        var module = new Module();
    //        module.Dir = node.ChildNodes.Item(i).Attributes.Item(0).Value;
    //        module.Name = node.ChildNodes.Item(i).Attributes.Item(1).Value;
    //        module.Long_name = node.ChildNodes.Item(i).Attributes.Item(2).Value;
    //        module.Url =node.ChildNodes.Item(i).Attributes.Item(3).Value;
    //        module.Id = node.ChildNodes.Item(i).Attributes.Item(2).Value;
    //        module.Exam_required =node.ChildNodes.Item(i).Attributes.Item(3).Value;
    //        var topicList = new List<Topic>();
    //        for (int j = 0; j < node.ChildNodes.Item(i).ChildNodes.Count - 1; j++)
    //        {
    //          var topic = new Topic();
    //          topic.Dir = node.ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(0).Value;
    //          topic.Name = node.ChildNodes.Item(i).ChildNodes.Item(j).Attributes.Item(1).Value;
    //          topicList.Add(topic);
    //        }
    //        module.Topic = topicList;
    //        moduleList.Add(module);
    //      }
    //    }
    //    course.Module = moduleList;
    //    return course;
    //  }
    //}
  }

  public class Module
  {
    [XmlAttribute("dir")]
    public string Dir { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlAttribute("long_name")]
    public string LongName { get; set; }

    [XmlAttribute("url")]
    public string Url { get; set; }

    [XmlAttribute("id")]
    public string Id { get; set; }

    [XmlAttribute("exam_required")]
    public string ExamRequired { get; set; }

    [XmlElement("topic")]
    public List<CourseTopic> Topic { get; set; }
  }
}