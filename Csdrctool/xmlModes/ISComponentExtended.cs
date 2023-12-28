using System.Xml.Serialization;
[XmlRoot("ISComponentExtended")]
public class ISComponentExtended
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("OS")]
     public string OS {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("FilterProperty")]
     public string FilterProperty {get;set;}
     [XmlAttribute("Platforms")]
     public string Platforms {get;set;}
     [XmlAttribute("FTPLocation")]
     public string FTPLocation {get;set;}
     [XmlAttribute("HTTPLocation")]
     public string HTTPLocation {get;set;}
     [XmlAttribute("Miscellaneous")]
     public string Miscellaneous {get;set;}
}
