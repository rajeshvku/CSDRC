using System.Xml.Serialization;
[XmlRoot("ISString")]
public class ISString
{
     [XmlAttribute("ISString")]
     public string ISStrings {get;set;}
     [XmlAttribute("ISLanguage_")]
     public string ISLanguage_ {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Encoded")]
     public string Encoded {get;set;}
     [XmlAttribute("Comment")]
     public string Comment {get;set;}
     [XmlAttribute("TimeStamp")]
     public string TimeStamp {get;set;}
}
