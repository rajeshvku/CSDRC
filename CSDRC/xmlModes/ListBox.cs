using System.Xml.Serialization;
[XmlRoot("ListBox")]
public class ListBox
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
