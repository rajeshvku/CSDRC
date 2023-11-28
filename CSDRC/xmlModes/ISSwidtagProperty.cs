using System.Xml.Serialization;
[XmlRoot("ISSwidtagProperty")]
public class ISSwidtagProperty
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
