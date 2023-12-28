using System.Xml.Serialization;
[XmlRoot("InstallShield")]
public class InstallShield
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
