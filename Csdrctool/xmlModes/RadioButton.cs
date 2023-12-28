using System.Xml.Serialization;
[XmlRoot("RadioButton")]
public class RadioButton
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("Value")]
     public string Value {get;set;}
     [XmlAttribute("X")]
     public string X {get;set;}
     [XmlAttribute("Y")]
     public string Y {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
     [XmlAttribute("Text")]
     public string Text {get;set;}
     [XmlAttribute("Help")]
     public string Help {get;set;}
     [XmlAttribute("ISControlId")]
     public string ISControlId {get;set;}
}
