using System.Xml.Serialization;
[XmlRoot("MIME")]
public class MIME
{
     [XmlAttribute("ContentType")]
     public string ContentType {get;set;}
     [XmlAttribute("Extension_")]
     public string Extension_ {get;set;}
     [XmlAttribute("CLSID")]
     public string CLSID {get;set;}
}
