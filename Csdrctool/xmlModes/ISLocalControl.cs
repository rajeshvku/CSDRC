using System.Xml.Serialization;
[XmlRoot("ISLocalControl")]
public class ISLocalControl
{
     [XmlAttribute("Dialog_")]
     public string Dialog_ {get;set;}
     [XmlAttribute("Control_")]
     public string Control_ {get;set;}
     [XmlAttribute("ISLanguage_")]
     public string ISLanguage_ {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("X")]
     public string X {get;set;}
     [XmlAttribute("Y")]
     public string Y {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
     [XmlAttribute("Binary_")]
     public string Binary_ {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
