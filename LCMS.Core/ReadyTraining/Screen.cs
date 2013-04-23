using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LCMS.Core.ReadyTraining
{
  public class Screen
  {
    [XmlAttribute("title")]
    public string Title { get; set; }

    [XmlAttribute("titlecolor")]
    public string TitleColor { get; set; }

    [XmlAttribute("defaultTextColor")]
    public string DefaulTextColor { get; set; }

    [JsonConverter(typeof(StringEnumConverter))]
    [XmlAttribute("template")]
    public ScreenTemplate Template { get; set; }

    [XmlAttribute("background")]
    public string BackGround { get; set; }

    [XmlAttribute("timer_overide")]
    public int TimerOveride { get; set; }

    [XmlElement("htmltext", typeof (Cdata))]
    public Cdata Htmltext { get; set; }

    [XmlElement("heading1")]
    public TextWithColor Heading1 { get; set; }

    [XmlElement("heading2")]
    public TextWithColor Heading2 { get; set; }

    [XmlElement("body")]
    public TextWithColor Body { get; set; }

    [XmlElement("instructions",typeof(Cdata))]
    public Cdata Instructions { get; set; }

    [XmlAttribute("subduedBackNext")]
    public bool IsSubduedBackNext { get; set; }

    [XmlElement("intro_text")]
    public TextWithDelay IntroText { get; set; }

    [XmlElement("outro_text")]
    public TextWithDelay OutroText { get; set; }

    [XmlElement("bullets")]
    public BulletList Bullets { get; set; }

    [XmlElement("feedback_start")]
    public string FeedbackStart { get; set; }

    [XmlElement("flash")]
    public Flash Flash { get; set; }

    [XmlElement("audio")]
    public Audio Audio { get; set; }

    [XmlElement("video")]
    public Video Video { get; set; }

    [XmlElement("doc")]
    public Doc Doc { get; set; }

    [XmlAttribute("exam")]
    public bool Exam { get; set; }

    [XmlAttribute("exam_num")]
    public int ExamNum { get; set; }

    [XmlAttribute("attempts")]
    public int Attempts { get; set; }
  }

  public enum ScreenTemplate
  {
    FlashRight,
    FlashLeft,
    ImageRight,
    ImageLeft,
    FlashFull,
    MultipleChoice,
    MP3PlayerRight,
    MP3PlayerLeft,
    MP3PlayerFlashFull,
    TopicIntro,
    TopicIntro2,
    PDFViewer,
    ExamResults,
    BulletListBuilder,
    VideoFullPlayer,
    Exam
  }


  public class TextWithDelay
  {
    [XmlAttribute("delay")]
    public int Delay { get; set; }
    [XmlAttribute("target")]
    public string Target { get; set; }
     [XmlText]
    public string Text { get; set; }
  }

  public class TextWithColor
  {
    [XmlAttribute("textColor")]
    public string TextColor { get; set; }
    [XmlText]
    public string Text { get; set; }
  }
}