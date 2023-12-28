using System.Xml.Serialization;
[XmlRoot("ListView")]
public class ListView
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
     [XmlAttribute("Binary_")]
     public string Binary_ {get;set;}
}
