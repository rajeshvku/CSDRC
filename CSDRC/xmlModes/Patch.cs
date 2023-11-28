using System.Xml.Serialization;
[XmlRoot("Patch")]
public class Patch
{
     [XmlAttribute("File_")]
     public string File_ {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("PatchSize")]
     public string PatchSize {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Header")]
     public string Header {get;set;}
     [XmlAttribute("StreamRef_")]
     public string StreamRef_ {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
