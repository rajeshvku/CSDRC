using System.Xml.Serialization;
[XmlRoot("ControlCondition")]
public class ControlCondition
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("Control_")]
     public string Control_ {get;set;}
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
}
