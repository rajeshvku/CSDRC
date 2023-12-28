using System.Xml.Serialization;
[XmlRoot("CustomAction")]
public class CustomAction
{
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("Source")]
     public string Source {get;set;}
     [XmlAttribute("Target")]
     public string Target {get;set;}
     [XmlAttribute("ExtendedType")]
     public string ExtendedType {get;set;}
     [XmlAttribute("ISComments")]
     public string ISComments {get;set;}
}
