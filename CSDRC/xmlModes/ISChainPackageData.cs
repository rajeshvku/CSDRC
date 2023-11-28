using System.Xml.Serialization;
[XmlRoot("ISChainPackageData")]
public class ISChainPackageData
{
     [XmlAttribute("Package_")]
     public string Package_ {get;set;}
     [XmlAttribute("File")]
     public string File {get;set;}
     [XmlAttribute("FilePath")]
     public string FilePath {get;set;}
     [XmlAttribute("Options")]
     public string Options {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
}
