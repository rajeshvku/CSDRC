using System.Xml.Serialization;
[XmlRoot("ISDIMVariable")]
public class ISDIMVariable
{
     [XmlAttribute("ISDIMVariable")]
     public string ISDIMVariables {get;set;}
     [XmlAttribute("ISDIMReference_")]
     public string ISDIMReference_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("NewValue")]
     public string NewValue {get;set;}
     [XmlAttribute("Type")]
     public string Type {get;set;}
}
