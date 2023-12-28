using System.Xml.Serialization;
[XmlRoot("BindImage")]
public class BindImage
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Path")]
     public string Path {get;set;}
}
