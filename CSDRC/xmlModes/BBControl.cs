using System.Xml.Serialization;
[XmlRoot("BBControl")]
public class BBControl
{
     [XmlAttribute("Billboard_")]
     public string Billboard_ {get;set;}
     [XmlAttribute("BBControl")]
     public string BBControls {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
     [XmlAttribute("X")]
     public string X {get;set;}
     [XmlAttribute("Y")]
     public string Y {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
}
