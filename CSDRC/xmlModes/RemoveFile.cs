using System.Xml.Serialization;
[XmlRoot("RemoveFile")]
public class RemoveFile
{
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("DirProperty")]
     public string DirProperty {get;set;}
     [XmlAttribute("InstallMode")]
     public string InstallMode {get;set;}
}
