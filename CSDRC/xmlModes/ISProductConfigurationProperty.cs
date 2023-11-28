using System.Xml.Serialization;
[XmlRoot("ISProductConfigurationProperty")]
public class ISProductConfigurationProperty
{
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
