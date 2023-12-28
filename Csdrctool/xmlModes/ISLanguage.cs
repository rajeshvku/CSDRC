using System.Xml.Serialization;
[XmlRoot("ISLanguage")]
public class ISLanguage
{
     [XmlAttribute("ISLanguage")]
     public string ISLanguages {get;set;}
     [XmlAttribute("Included")]
     public string Included {get;set;}
}
