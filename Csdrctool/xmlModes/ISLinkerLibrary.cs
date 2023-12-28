using System.Xml.Serialization;
[XmlRoot("ISLinkerLibrary")]
public class ISLinkerLibrary
{
     [XmlAttribute("ISLinkerLibrary")]
     public string ISLinkerLibrarys {get;set;}
     [XmlAttribute("Library")]
     public string Library {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
}
