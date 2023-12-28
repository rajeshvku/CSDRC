using System.Xml.Serialization;
[XmlRoot("ISDIMReferenceDependencies")]
public class ISDIMReferenceDependencies
{
     [XmlAttribute("ISDIMReference_Parent")]
     public string ISDIMReference_Parent {get;set;}
     [XmlAttribute("ISDIMDependency_")]
     public string ISDIMDependency_ {get;set;}
}
