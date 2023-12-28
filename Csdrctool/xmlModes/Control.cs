using System.Xml.Serialization;
[XmlRoot("Control")]
public class Control
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("Control")]
     public string Controls {get;set;}
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
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
     [XmlAttribute("Control_Next")]
     public string Control_Next {get;set;}
     [XmlAttribute("Help")]
     public string Help {get;set;}
     [XmlAttribute("ISWindowStyle")]
     public string ISWindowStyle {get;set;}
     [XmlAttribute("ISControlId")]
     public string ISControlId {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("Binary_")]
     public string Binary_ {get;set;}
}
