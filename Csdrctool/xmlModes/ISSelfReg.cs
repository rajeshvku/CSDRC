using System.Xml.Serialization;
[XmlRoot("ISSelfReg")]
public class ISSelfReg
{
     [XmlAttribute("FileKey")]
     public string FileKey {get;set;}
     [XmlAttribute("Cost")]
     public string Cost {get;set;}
     [XmlAttribute("Order")]
     public string Order {get;set;}
     [XmlAttribute("CmdLine")]
     public string CmdLine {get;set;}
}
