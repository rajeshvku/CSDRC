using System.Xml.Serialization;
[XmlRoot("ODBCDriver")]
public class ODBCDriver
{
     [XmlAttribute("Driver")]
     public string Driver {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("Description")]
     public string Description {get;set;}
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("File_Setup")]
     public string File_Setup {get;set;}
}
