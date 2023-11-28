using System.Xml.Serialization;
[XmlRoot("Condition")]
public class Condition
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Level")]
     public string Level {get;set;}
     [XmlAttribute("Condition")]
     public string Conditions {get;set;}
}
