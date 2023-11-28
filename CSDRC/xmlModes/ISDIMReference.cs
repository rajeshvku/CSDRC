using System.Xml.Serialization;
[XmlRoot("ISDIMReference")]
public class ISDIMReference
{
     [XmlAttribute("ISDIMReference")]
     public string ISDIMReferences {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
