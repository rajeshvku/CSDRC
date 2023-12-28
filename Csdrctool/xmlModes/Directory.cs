using System.Xml.Linq;
using System.Xml.Serialization;
[XmlRoot("Directory")]
public class Directory
{
     [XmlAttribute("Directory")]
     public string Directorys {get;set;}
     [XmlAttribute("Directory_Parent")]
     public string Directory_Parent {get;set;}
     [XmlAttribute("DefaultDir")]
     public string DefaultDir {get;set;}
     [XmlAttribute("ISDescription")]
     public string ISDescription {get;set;}
     [XmlAttribute("ISAttributes")]
     public string ISAttributes {get;set;}
     [XmlAttribute("ISFolderName")]
     public string ISFolderName {get;set;}
    public string GetDirectory()
    {
        return $"<Directory Id=\"{Directorys}Dir\"\r\nName=\"SourceDir\">";
    }
    public string GetDirectoryRef()
    {
        return $"<DirectoryRef Id=\"{Directorys}Dir\">";
    }
}
