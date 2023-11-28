using System.Xml.Serialization;
[XmlRoot("ISSetupTypeFeatures")]
public class ISSetupTypeFeatures
{
     [XmlAttribute("ISSetupType_")]
     public string ISSetupType_ {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
}
