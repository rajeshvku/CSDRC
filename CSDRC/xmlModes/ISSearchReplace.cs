using System.Xml.Serialization;
[XmlRoot("ISSearchReplace")]
public class ISSearchReplace
{
     [XmlAttribute("ISSearchReplace")]
     public string ISSearchReplaces {get;set;}
     [XmlAttribute("ISSearchReplaceSet_")]
     public string ISSearchReplaceSet_ {get;set;}
     [XmlAttribute("Search")]
     public string Search {get;set;}
     [XmlAttribute("Replace")]
     public string Replace {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
}
