using System.Xml.Serialization;
[XmlRoot("Error")]
public class Error
{
     [XmlAttribute("Error")]
     public string Errors {get;set;}
     [XmlAttribute("Message")]
     public string Message {get;set;}
}
