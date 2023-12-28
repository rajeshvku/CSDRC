using System.Xml.Serialization;
[XmlRoot("ISProductConfiguration")]
public class ISProductConfiguration
{
     [XmlAttribute("ISProductConfiguration")]
     public string ISProductConfigurations {get;set;}
     [XmlAttribute("ProductConfigurationFlags")]
     public string ProductConfigurationFlags {get;set;}
     [XmlAttribute("GeneratePackageCode")]
     public string GeneratePackageCode {get;set;}
}
