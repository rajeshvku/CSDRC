using System.Xml.Serialization;
[XmlRoot("MsiPatchOldAssemblyFile")]
public class MsiPatchOldAssemblyFile
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Assembly_")]
     public string Assembly_ {get;set;}
}
