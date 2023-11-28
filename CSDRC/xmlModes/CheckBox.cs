using System.Xml.Serialization;
[XmlRoot("CheckBox")]
public class CheckBox
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
}
