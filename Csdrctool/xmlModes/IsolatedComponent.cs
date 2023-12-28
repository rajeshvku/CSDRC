using System.Xml.Serialization;
[XmlRoot("IsolatedComponent")]
public class IsolatedComponent
{
     [XmlAttribute("Component_Shared")]
     public string Component_Shared {get;set;}
     [XmlAttribute("Component_Application")]
     public string Component_Application {get;set;}
}
