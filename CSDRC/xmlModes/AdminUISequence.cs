using System.Xml.Serialization;
[XmlRoot("AdminUISequence")]
public class AdminUISequence
{
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
