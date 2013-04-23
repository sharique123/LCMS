using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace LCMS.Core.ReadyTraining
{
  [XmlRoot("exam")]
  public class Exam
  {
    [XmlElement("question")]
    public List<Question> Question { get; set; }
  }

  public class Question
  {
    [XmlAttribute("template")]
    public string Template { get; set; }

    [XmlAttribute("type")]
    public string Type { get; set; }

    [XmlAttribute("defaultTextColor")]
    public string DefaultTextColor { get; set; }

    [XmlAttribute("background")]
    public string BackGround { get; set; }

    [XmlAttribute("id")]
    public int Id { get; set; }

    [XmlElement("choice")]
    public List<MultipleChoiceOptions> Choice { get; set; }

    [XmlElement("feedback_correct")]
    public string FeedbackCorrect { get; set; }

    [XmlElement("feedback_incorrect")]
    public string FeedbackInCorrect { get; set; }

    [XmlElement("expert")]
    public ExamExpert ExpertPath { get; set; }
  }

  public class ExamExpert
  {
    private int _index = 1;
    private string _text = "";

    [XmlAttribute("path")]
    public string Path { get; set; }

    [XmlAttribute("parameters")]
    public string Parameters { get; set; }

    [XmlElement("expert_text")]
    public String ExpertText
    {
      get
      {
        if (Parameters != null)
        {
          var i = Parameters.Split(Convert.ToChar("|"));

          if (i.Length == 2)
          {
            _text = i[1];
          }
        }
        return _text;
      }
      set { _text = value; }
    }

    [XmlElement("expert_image_index")]
    public int ExpertImageIndex
    {
      get
      {
        if (Parameters != null)
        {
          var i = Parameters.Split(Convert.ToChar("|"));

          if (i.Length == 2)
          {
            _index = Convert.ToInt32(i[0]);
          }
        }
        return _index;
      }
      set { _index = value; }
    }
  }

  public class MultipleChoiceOptions
  {
    [XmlText]
    public string ChoiceOption { get; set; }

    [XmlAttribute("correct")]
    public int Correct { get; set; }
  }
}