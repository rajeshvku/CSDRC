using System.Xml.Serialization;
[XmlRoot("TypeLib")]
public class TypeLib
{
     [XmlAttribute("LibID")]
     public string LibID {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Version")]
     public string Version {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Cost")]
     public string Cost {get;set;}
}
