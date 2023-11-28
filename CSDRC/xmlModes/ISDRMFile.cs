using System.Xml.Serialization;
[XmlRoot("ISDRMFile")]
public class ISDRMFile
{
     [XmlAttribute("ISDRMFile")]
     public string ISDRMFiles {get;set;}
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("ISDRMLicense_")]
     public string ISDRMLicense_ {get;set;}
     [XmlAttribute("Shell")]
     public string Shell {get;set;}
}
