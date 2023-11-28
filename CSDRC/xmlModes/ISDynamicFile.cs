using System.Xml.Serialization;
[XmlRoot("ISDynamicFile")]
public class ISDynamicFile
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("SourceFolder")]
     public string SourceFolder {get;set;}
     [XmlAttribute("IncludeFlags")]
     public string IncludeFlags {get;set;}
     [XmlAttribute("IncludeFiles")]
     public string IncludeFiles {get;set;}
     [XmlAttribute("ExcludeFiles")]
     public string ExcludeFiles {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
}
