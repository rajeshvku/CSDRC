using System.Xml.Serialization;
[XmlRoot("MsiAssembly")]
public class MsiAssembly
{
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Feature_")]
     public string Feature_ {get;set;}
     [XmlAttribute("File_Manifest")]
     public string File_Manifest {get;set;}
     [XmlAttribute("File_Application")]
     public string File_Application {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
}
