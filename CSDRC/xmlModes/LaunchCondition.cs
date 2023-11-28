using System.Xml.Serialization;
[XmlRoot("LaunchCondition")]
public class LaunchCondition
{
     [XmlAttribute("Condition")]
     public string Condition {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
}
