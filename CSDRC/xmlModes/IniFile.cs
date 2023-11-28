using System.Xml.Serialization;
[XmlRoot("IniFile")]
public class IniFile
{
     [XmlAttribute("IniFile")]
     public string IniFiles {get;set;}
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
