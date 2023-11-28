using System.Xml.Serialization;
[XmlRoot("ISDRMFileAttribute")]
public class ISDRMFileAttribute
{
     [XmlAttribute("ISDRMFile_")]
     public string ISDRMFile_ {get;set;}
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
