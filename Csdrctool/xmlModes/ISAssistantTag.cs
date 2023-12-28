using System.Xml.Serialization;
[XmlRoot("ISAssistantTag")]
public class ISAssistantTag
{
     [XmlAttribute("Tag")]
     public string Tag {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
}
