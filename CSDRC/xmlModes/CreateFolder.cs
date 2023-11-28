using System.Xml.Serialization;
[XmlRoot("CreateFolder")]
public class CreateFolder
{
     [XmlAttribute("Directory_")]
     public string Directory_ {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
}
