using System.Xml.Serialization;
[XmlRoot("FeatureComponents")]
public class FeatureComponents
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
