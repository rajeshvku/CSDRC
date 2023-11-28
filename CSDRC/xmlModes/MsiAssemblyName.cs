using System.Xml.Serialization;
[XmlRoot("MsiAssemblyName")]
public class MsiAssemblyName
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
