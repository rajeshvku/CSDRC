using System.Xml.Serialization;
[XmlRoot("ISProductConfigurationInstance")]
public class ISProductConfigurationInstance
{
     [XmlAttribute("ISProductConfiguration_")]
     public string ISProductConfiguration_ {get;set;}
     [XmlAttribute("InstanceId")]
     public string InstanceId {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
