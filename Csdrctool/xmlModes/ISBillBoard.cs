using System.Xml.Serialization;
[XmlRoot("ISBillBoard")]
public class ISBillBoard
{
     [XmlAttribute("ISBillboard")]
     public string ISBillboard {get;set;}
     [XmlAttribute("Duration")]
     public string Duration {get;set;}
     [XmlAttribute("Origin")]
     public string Origin {get;set;}
     [XmlAttribute("X")]
     public string X {get;set;}
     [XmlAttribute("Y")]
     public string Y {get;set;}
     [XmlAttribute("Effect")]
     public string Effect {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("Target")]
     public string Target {get;set;}
     [XmlAttribute("Color")]
     public string Color {get;set;}
     [XmlAttribute("Style")]
     public string Style {get;set;}
     [XmlAttribute("Font")]
     public string Font {get;set;}
     [XmlAttribute("Title")]
     public string Title {get;set;}
     [XmlAttribute("DisplayName")]
     public string DisplayName {get;set;}
}
