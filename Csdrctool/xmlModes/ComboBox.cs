using System.Xml.Serialization;
[XmlRoot("ComboBox")]
public class ComboBox
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
}
