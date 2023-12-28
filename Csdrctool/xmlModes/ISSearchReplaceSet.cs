using System.Xml.Serialization;
[XmlRoot("ISSearchReplaceSet")]
public class ISSearchReplaceSet
{
     [XmlAttribute("ISSearchReplaceSet")]
     public string ISSearchReplaceSets {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("IncludeFiles")]
     public string IncludeFiles {get;set;}
     [XmlAttribute("ExcludeFiles")]
     public string ExcludeFiles {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("CodePage")]
     public string CodePage {get;set;}
}
