using System.Xml.Serialization;
[XmlRoot("RemoveIniFile")]
public class RemoveIniFile
{
     [XmlAttribute("RemoveIniFile")]
     public string RemoveIniFiles {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("DirProperty")]
     public string DirProperty {get;set;}
     [XmlAttribute("Section")]
     public string Section {get;set;}
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
