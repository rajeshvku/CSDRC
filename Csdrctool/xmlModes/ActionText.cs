using System.Xml.Serialization;
[XmlRoot("ActionText")]
public class ActionText
{
     [XmlAttribute("Action")]
     public string Action {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("Template")]
     public string Template {get;set;}
}
