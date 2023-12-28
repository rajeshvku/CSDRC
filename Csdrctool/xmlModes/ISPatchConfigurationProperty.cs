using System.Xml.Serialization;
[XmlRoot("ISPatchConfigurationProperty")]
public class ISPatchConfigurationProperty
{
     [XmlAttribute("ISPatchConfiguration_")]
     public string ISPatchConfiguration_ {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
