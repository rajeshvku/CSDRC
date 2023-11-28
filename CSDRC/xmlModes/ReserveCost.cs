using System.Xml.Serialization;
[XmlRoot("ReserveCost")]
public class ReserveCost
{
     [XmlAttribute("ReserveKey")]
     public string ReserveKey {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("ReserveFolder")]
     public string ReserveFolder {get;set;}
     [XmlAttribute("ReserveLocal")]
     public string ReserveLocal {get;set;}
     [XmlAttribute("ReserveSource")]
     public string ReserveSource {get;set;}
}
