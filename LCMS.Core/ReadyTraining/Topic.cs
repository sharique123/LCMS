using System.Collections.Generic;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  public abstract class Topic
  {
    [XmlAttribute("dir")]
    public string Dir { get; set; }

    [XmlAttribute("name")]
    public string Name { get; set; }

    [XmlElement("screen")]
    public List<Screen> Screen { get; set; }
  }

  public class CourseTopic : Topic{}

  [XmlRoot("topic")]
  public class ScreenTopic : Topic
  {
    [XmlAttribute("type")]
    public string Type { get; set; }

    [XmlAttribute("Exam_start_screen")]
    public int ExamStartScreen { get; set; }

    [XmlAttribute("Exam_questions")]
    public int ExamQuestions { get; set; }

    [XmlAttribute("pass_percentage")]
    public int PassPercentage { get; set; }
  }

  
}