using System.Xml.Serialization;
[XmlRoot("ISFeatureDIMs")]
public class ISFeatureDIMs
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("ISDIM_")]
     public string ISDIM_ {get;set;}
}
