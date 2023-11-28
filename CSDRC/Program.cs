using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Globalization;
using CSDRC;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        //string xmlString = "C:\\Users\\Rajesh\\Downloads\\ism_file_v1.xml";


        //XDocument xdoc = XDocument.Load(xmlString);

        //// Find all "Table" elements
        //var tabless = xdoc.Descendants("table");
        //using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\pathVariables.html");
        //sw.WriteLine("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n<head>\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <link href=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css\" rel=\"stylesheet\" integrity=\"sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN\" crossorigin=\"anonymous\">\r\n    <title>Document</title>\r\n</head>\r\n<body>\r\n");

        //foreach (var table in tabless)
        //{
        //    string tableName = table.Attribute("name")?.Value;
            
        //    sw.WriteLine($"<h1>{tableName}</h1>");
        //    sw.WriteLine($"<table class=\"table table-bordered border-primary table-striped-columns\">\r\n  <thead>\r\n    <tr>");
        //    foreach (var column in table.Elements("col"))
        //    {
        //        string columnName = column.Attribute("name")?.Value;
        //        string columnValue = column.Value;
                
        //        sw.WriteLine($"<th scope=\"col\"> {columnValue}</th>");
               
        //    }
        //    sw.WriteLine("</tr>\r\n  </thead>\r\n  <tbody>");

        //    foreach(var row in table.Descendants("row"))
        //    {
        //        sw.WriteLine("<tr>");
        //        sw.WriteLine(row.ToString().Replace("<row>","").Replace("</row>",""));
        //        sw.WriteLine("</tr>");
        //        //foreach (var col in row.Elements())
        //        //{
        //        //    // Extract the text content
        //        //    string columnName = col.Name.LocalName;
        //        //    string columnValue = col.Value;
        //        //    sw.WriteLine($" <td>Mark</td>{columnName} {columnValue}");
        //        //    // Output the result
        //        //    Console.WriteLine($"{columnName}: {columnValue}");
        //        //}
        //        //sw.WriteLine("</tr>");
        //    }

        //    //if (tableName == "ISPathVariable")
        //    //{
        //    //    using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\pathVariables.txt");

        //    //    var reows = table.Elements("row");
        //    //    List<ISPathVariable> isPathVariableList = table.Descendants("row").Select(row =>
        //    //    new ISPathVariable
        //    //    {
        //    //        ISPathVariables = row.Element("td")?.Value,
        //    //        Value = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
        //    //        TestValue = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
        //    //        Type = row.Elements("td").Skip(3).FirstOrDefault()?.Value
        //    //    }).ToList();
        //    //    foreach (var pathVariable in isPathVariableList)
        //    //    {
        //    //        var stringVariable = $"<String Id=\"{pathVariable.ISPathVariables}\">{pathVariable.Value}</String>";
        //    //        sw.WriteLine(stringVariable);
        //    //    }


        //    //}
        //    //if (tableName == "Component")
        //    //{
        //    //    using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\pathVariables.txt");

        //    //    var reows = table.Elements("row");
        //    //    List<Component> isPathVariableList = table.Descendants("row").Select(row =>
        //    //    new Component
        //    //    {
        //    //        Components = row.Element("td")?.Value,
        //    //        ComponentId = Guid.NewGuid().ToString(),
        //    //        Directory_ = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
        //    //        Attributes = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
        //    //        Condition = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
        //    //        KeyPath = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
        //    //        ISAttributes = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
        //    //        ISScanAtBuildFile = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
        //    //        ISRegFileToMergeAtBuild = row.Elements("td").Skip(7).FirstOrDefault()?.Value,
        //    //        ISDotNetInstallerArgsInstall = row.Elements("td").Skip(8).FirstOrDefault()?.Value,
        //    //        ISDotNetInstallerArgsCommit = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
        //    //        ISDotNetInstallerArgsUninstall = row.Elements("td").Skip(10).FirstOrDefault()?.Value,
        //    //        ISDotNetInstallerArgsRollback = row.Elements("td").Skip(10).FirstOrDefault()?.Value,
        //    //    }).ToList();
        //    //    foreach (var pathVariable in isPathVariableList)
        //    //    {
        //    //        //var stringVariable = $"<String Id=\"{pathVariable.ISPathVariables}\">{pathVariable.Value}</String>";
        //    //        //sw.WriteLine(stringVariable);
        //    //    }

        //    //    sw.Close();
        //    //}

        //    sw.WriteLine("</tbody>\r\n</table>");

        //}
        //sw.WriteLine("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL\" crossorigin=\"anonymous\"></script>\r\n</body>\r\n</html>");

        //sw.Close();





        //string xmlString = "C:\\Users\\Rajesh\\Downloads\\ism_file_v1.xml";

        //XDocument xdoc = XDocument.Load(xmlString);

        //// Find all "Table" elements
        //var tabless = xdoc.Descendants("table");

        //foreach (var table in tabless)
        //{
        //    string pthstr = "E:\\Personal\\CSDRC\\CSDRC\\xmlModes\\";
        //    // Access the "name" attribute value of each "Table" element
        //    string tableName = table.Attribute("name")?.Value;
        //    Console.WriteLine($"Table name: {tableName}");
        //    List<string> columns = new List<string>();
        //    using StreamWriter sw = new StreamWriter($"{pthstr}{tableName}.cs");
        //    sw.WriteLine($"using System.Xml.Serialization;");
        //    sw.WriteLine($"[XmlRoot(\"{tableName}\")]");
        //    sw.WriteLine($"public class {tableName}");
        //    sw.WriteLine("{");
        //    foreach (var column in table.Elements("col"))
        //    {
        //        // Access the "name" and text value of each "Column" element
        //        string columnName = column.Attribute("name")?.Value;
        //        string columnValue = column.Value;
        //        columns.Add(columnValue);
        //        sw.WriteLine($"     [XmlAttribute(\"{columnValue}\")]");
        //        if (columnValue == tableName)
        //        {
        //            sw.WriteLine($"     public string " + columnValue+"s" + " {get;set;}");
        //        }
        //        else
        //        {
        //            sw.WriteLine($"     public string " + columnValue + " {get;set;}");
        //        }

        //        Console.WriteLine($"Column name: {columnName}, Column value: {columnValue}");
        //    }
        //    sw.WriteLine("}");
        //    sw.Close();
        //   // using StreamWriter sw = new StreamWriter($"{pthstr}{tableName}.cs");


        //}


        //List<Table> tables = xdoc.Root.Elements("table")
        //    .Select(tableElem => new Table
        //    {
        //        TableName = (string)tableElem.Attribute("name"),
        //        Rows = tableElem.Elements("row")
        //            .Select(rowElem => new Row
        //            {
        //                Columns = rowElem.Elements("col")
        //                    .Select(colElem => new Column
        //                    {
        //                        Definition = (string)colElem.Attribute("def"),
        //                        IsKey = (string)colElem.Attribute("key"),
        //                        Value = (string)colElem
        //                    })
        //                    .ToList()
        //            })
        //            .ToList()
        //    })
        //    .ToList();

        //foreach (var table in tables)
        //{
        //    Console.WriteLine($"Table Name: {table.TableName}");

        //    foreach (var row in table.Rows)
        //    {
        //        Console.WriteLine("Row:");

        //        foreach (var column in row.Columns)
        //        {
        //            Console.WriteLine($"  Column Definition: {column.Definition}, Is Key: {column.IsKey}, Value: {column.Value}");
        //        }
        //    }
        //}

        //string root = @"C:\Users\Rajesh\Downloads\IS2WiX-master\xsl";
        //string root2 = @"C:\Users\Rajesh\Downloads\IS2WiX-master\output\";
        //var files = from file in Directory.EnumerateFiles(root) select file;
        //foreach (var file in files)
        //{
        //    try
        //    {
        //        var baseFileName = Path.GetFileNameWithoutExtension(file);
        //        XPathDocument myXPathDoc = new XPathDocument("C:\\Users\\Rajesh\\Downloads\\ism_file_v1.xml");
        //        XslCompiledTransform myXslTrans = new XslCompiledTransform();
        //        myXslTrans.Load(file);
        //        XmlTextWriter myWriter = new XmlTextWriter(root2 + baseFileName + ".xml", null);
        //        myXslTrans.Transform(myXPathDoc, null, myWriter);
        //    }
        //    catch (Exception ex)
        //    {


        //    }

        //}



        String line;
        string xmlStrisg = "E:\\Personal\\CSDRC\\Test.Wixtool\\PathVariables.wxl";
        XDocument xDoc = XDocument.Load(xmlStrisg);
        XNamespace nse = "http://schemas.microsoft.com/wix/2006/localization";

        foreach (var element in xDoc.Descendants(nse + "String"))
        {
            string id = element.Attribute("Id").Value;
            string pascalCase = ToPascalCase(id);
            string value = element.Value;
            //md.Add(new MasterD { Id = id, Value = value });
            Console.WriteLine($"Id: {id}, Value: {value}");
            element.SetAttributeValue("Id", pascalCase.Replace("_",""));

        }
        xDoc.Save("E:\\Personal\\CSDRC\\Test.Wixtool\\PathVariablesd.wxl");
        //try
        //{
        //    //Pass the file path and file name to the StreamReader constructor
        //    StreamReader sr = new StreamReader("C:\\Users\\Rajesh\\Documents\\stringMessage.txt");
        //    StreamWriter sw = new StreamWriter("C:\\Users\\Rajesh\\Documents\\wixMessageas.txt");
        //    //Read the first line of text
        //    line = sr.ReadLine();
        //    //Continue to read until you reach end of file
        //    while (line != null)
        //    {

        //        var splittedLi = line.Split('=');
        //        var valuestr = string.IsNullOrEmpty(splittedLi[1]) ? string.Empty : splittedLi[1];
        //        string pascalCase = ToPascalCase(splittedLi[0]);
        //        var newTag = $"<String Id=\"{pascalCase.Replace("_","")}\">{valuestr}</String>";

        //        sw.WriteLine(newTag);
        //        //write the line to console window
        //        Console.WriteLine(newTag);
        //        //Read the next line
        //        line = sr.ReadLine();
        //    }
        //    //close the file
        //    sr.Close();
        //    sw.Close();
        //    Console.ReadLine();
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine("Exception: " + e.Message);
        //}
        //finally
        //{
        //    Console.WriteLine("Executing finally block.");
        //}
        Console.ReadLine();

    }
    static string ToPascalCase(string input)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.ToLower());
    }
}
[XmlRoot("table")]
public class Table
{
    [XmlAttribute("name")]
    public string TableName { get; set; }

    [XmlElement("row")]
    public List<Row> Rows { get; set; }
}

public class Row
{
    [XmlElement("col")]
    public List<Column> Columns { get; set; }
}

public class Column:ISPathVariable
{
    
}