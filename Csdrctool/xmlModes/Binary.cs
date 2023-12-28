using System.Xml.Serialization;
[XmlRoot("Binary")]
public class Binary
{
     [XmlAttribute("Name")]
     public string Name {get;set;}
     [XmlAttribute("Data")]
     public string Data {get;set;}
     [XmlAttribute("ISBuildSourcePath")]
     public string ISBuildSourcePath {get;set;}

    public string GetBinarySet { get
        {
            return $"<Binary Id=\"{Name}\"\r\nSourceFile=\r\n\"{GetBinaryPath(ISBuildSourcePath)}\" />";
        } 
    }
    public string GetBinaryPath(string path)
    {
        return path.Replace("<", "$(").Replace(">",")");
    }
}
