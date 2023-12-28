using System.Xml.Serialization;
[XmlRoot("Billboard")]
public class Billboard
{
     [XmlAttribute("Billboard")]
     public string Billboards {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Ordering")]
     public string Ordering {get;set;}
}
