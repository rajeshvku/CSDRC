using System.Xml.Serialization;
[XmlRoot("File")]
public class File
{
     [XmlAttribute("File")]
     public string Files {get;set;}
     [XmlAttribute("Component_")]
     public string Component_ {get;set;}
     [XmlAttribute("FileName")]
     public string FileName {get;set;}
     [XmlAttribute("FileSize")]
     public string FileSize {get;set;}
     [XmlAttribute("Version")]
     public string Version {get;set;}
     [XmlAttribute("Language")]
     public string Language {get;set;}
     [XmlAttribute("Attributes")]
     public string Attributes {get;set;}
     [XmlAttribute("Sequence")]
     public string Sequence {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("ISComponentSubFolder_")]
     public string ISComponentSubFolder_ {get;set;}
    public string GetFile { get
    {
            return $"<File Id=\"{RemoveExtension(Files)}File\"\r\nName=\"{Files}\" \r\nSource=\"{ISBuildSourcePath.Replace("<","$(loc.").Replace(">", ")")}\"" +
                "\r\nKeyPath=\"yes\" />";
        } }
    string RemoveExtension(string filePath)
    {
        // Find the last occurrence of '.' to identify the beginning of the extension
        int lastDotIndex = filePath.LastIndexOf('.');

        // If '.' is found, extract the substring before it; otherwise, return the original string
        return lastDotIndex >= 0 ? filePath.Substring(0, lastDotIndex) : filePath;
    }
}
