using System.Xml.Serialization;
[XmlRoot("ISLocalRadioButton")]
public class ISLocalRadioButton
{
     [XmlAttribute("Property")]
     public string Property {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("ISLanguage_")]
     public string ISLanguage_ {get;set;}
     [XmlAttribute("X")]
     public string X {get;set;}
     [XmlAttribute("Y")]
     public string Y {get;set;}
     [XmlAttribute("Width")]
     public string Width {get;set;}
     [XmlAttribute("Height")]
     public string Height {get;set;}
}
