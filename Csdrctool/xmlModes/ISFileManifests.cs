using System.Xml.Serialization;
[XmlRoot("ISFileManifests")]
public class ISFileManifests
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Manifest_")]
     public string Manifest_ {get;set;}
}
