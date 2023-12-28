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

    public string GetDirectory { get { return $"<Directory Id=\"{Directorys}\"\r\nName=\"{DefaultDir}\">"; } }
    public string EndDirectory = "</Directory>";
    public string GetDirectoryRef { get { return $"<DirectoryRef Id=\"{Directorys}\">"; } }
    public string EndDirectoryRef = "</DirectoryRef>";
}
