using System.Xml.Serialization;
[XmlRoot("ISFeatureDIMReferences")]
public class ISFeatureDIMReferences
{
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("ISDIMReference_")]
     public string ISDIMReference_ {get;set;}
}
