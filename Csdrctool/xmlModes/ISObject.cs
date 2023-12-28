using System.Xml.Serialization;
[XmlRoot("ISObject")]
public class ISObject
{
     [XmlAttribute("ObjectName")]
     public string ObjectName {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
}
