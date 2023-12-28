using System.Xml.Serialization;
[XmlRoot("MsiPatchMetadata")]
public class MsiPatchMetadata
{
     [XmlAttribute("PatchConfiguration_")]
     public string PatchConfiguration_ {get;set;}
     [XmlAttribute("Company")]
     public string Company {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
