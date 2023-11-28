using System.Xml.Serialization;
[XmlRoot("IniLocator")]
public class IniLocator
{
     [XmlAttribute("Signature_")]
     public string Signature_ {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("Section")]
     public string Section {get;set;}
     [XmlAttribute("Key")]
     public string Key {get;set;}
     [XmlAttribute("Field")]
     public string Field {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
