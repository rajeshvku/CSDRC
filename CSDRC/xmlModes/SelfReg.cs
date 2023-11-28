using System.Xml.Serialization;
[XmlRoot("SelfReg")]
public class SelfReg
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Cost")]
     public string Cost {get;set;}
}
