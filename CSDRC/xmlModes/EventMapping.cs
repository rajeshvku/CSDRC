using System.Xml.Serialization;
[XmlRoot("EventMapping")]
public class EventMapping
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("Control_")]
     public string Control_ {get;set;}
     [XmlAttribute("Event")]
     public string Event {get;set;}
     [XmlAttribute("Attribute")]
     public string Attribute {get;set;}
}
