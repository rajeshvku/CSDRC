using System.Xml.Serialization;
[XmlRoot("ISDependency")]
public class ISDependency
{
     [XmlAttribute("ISDependency")]
     public string ISDependencys {get;set;}
     [XmlAttribute("Exclude")]
     public string Exclude {get;set;}
}
