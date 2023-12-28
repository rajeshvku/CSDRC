using System.Xml.XPath;
using System.Xml.Xsl;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Globalization;
using CSDRC;

internal class Program
{
    public static List<Directory> directories = new List<Directory>();
    public static List<Component> components = new List<Component>();
    public static List<Dialog> dialogs = new List<Dialog>();
    public static List<Control> controls = new List<Control>();
    public static List<ControlEvent> controlEvents = new List<ControlEvent>();
    public static List<ControlCondition> controlConditions = new List<ControlCondition>();
    public static List<CustomAction> customActions = new List<CustomAction>();
    public static List<File> files = new List<File>();
    public static List<Registry> registries = new List<Registry>();
    public static List<Property> properties = new List<Property>();
    public static List<RadioButton> radioButtons = new List<RadioButton>();

    private static void Main(string[] args)
    {
        //Console.WriteLine("Hello, World!");

        string xmlString = "D:\\backupdownloads\\ism_file_v1.xml";
        //string xmlString = "E:\\Personal\\CSDRC\\Test.Wixtool\\UIDialogs.wxs";


        XDocument xdoc = XDocument.Load(xmlString);
        // Append "dlg" to the Dialog Ids
        // AppendDlgToDialogIds(xdoc);

        // Save the modified XML content
        //xdoc.Save("E:\\Personal\\CSDRC\\Test.Wixtool\\ModifiedXmlFile.wxs");
        //// Find all "Table" elements
        var tabless = xdoc.Descendants("table");
        //using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\pathVariableshj.html");
        //sw.WriteLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>\r\n<Wix xmlns=\"http://schemas.microsoft.com/wix/2006/wi\">\r\n\t<Fragment>\r\n\t\t<UI>");

        foreach (var table in tabless)
        {
            string tableName = table.Attribute("name")?.Value;

            //sw.WriteLine($"<h1>{tableName}</h1>");
            //sw.WriteLine($"<table class=\"table table-bordered border-primary table-striped-columns\">\r\n  <thead>\r\n    <tr>");
            //foreach (var column in table.Elements("col"))
            //{
            //    string columnName = column.Attribute("name")?.Value;
            //    string columnValue = column.Value;

            //    sw.WriteLine($"<th scope=\"col\"> {columnValue}</th>");

            //}
            //sw.WriteLine("</tr>\r\n  </thead>\r\n  <tbody>");

            //foreach (var row in table.Descendants("row"))
            //{
            //    sw.WriteLine("<tr>");
            //    sw.WriteLine(row.ToString().Replace("<row>", "").Replace("</row>", ""));
            //    sw.WriteLine("</tr>");
            //    foreach (var col in row.Elements())
            //    {
            //        // Extract the text content
            //        string columnName = col.Name.LocalName;
            //        string columnValue = col.Value;
            //        sw.WriteLine($" <td>Mark</td>{columnName} {columnValue}");
            //        // Output the result
            //        Console.WriteLine($"{columnName}: {columnValue}");
            //    }
            //    sw.WriteLine("</tr>");
            //}

            if (tableName == "ISPathVariable")
            {
                using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\pathVariables.txt");

                var reows = table.Elements("row");
                List<ISPathVariable> isPathVariableList = table.Descendants("row").Select(row =>
                new ISPathVariable
                {
                    ISPathVariables = row.Element("td")?.Value,
                    Value = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    TestValue = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Type = row.Elements("td").Skip(3).FirstOrDefault()?.Value
                }).ToList();
                //foreach (var pathVariable in isPathVariableList)
                //{
                //    //var stringVariable = $"<String Id=\"{pathVariable.ISPathVariables}\">{pathVariable.Value}</String>";
                //    //sw.WriteLine(stringVariable);
                //}


            }
            if (tableName == "Directory")
            {
                using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\Directoriesss.txt");

                var reows = table.Elements("row");
                directories = table.Descendants("row").Select(row =>
                new Directory
                {
                    Directorys = row.Element("td")?.Value,
                    Directory_Parent = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    DefaultDir = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    ISDescription = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    ISAttributes = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    ISFolderName = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                }).ToList();

                if (directories.Any())
                {
                    
                    var parentItems = directories.Select(f => f.Directory_Parent).Distinct().OrderBy(p => string.IsNullOrEmpty(p));

                    foreach (var item in parentItems)
                    {
                        if (!string.IsNullOrEmpty(item))
                        {
                            var parentItem = directories.FirstOrDefault(g => g.Directorys == item);
                            sw.WriteLine(parentItem.GetDirectory);
                            var subDirectoris = directories.Where(g => g.Directory_Parent == item);
                            foreach (var subItem in subDirectoris)
                            {
                                sw.WriteLine(subItem.GetDirectory);
                                sw.WriteLine(subItem.EndDirectory);
                            }
                            sw.WriteLine(parentItem.EndDirectory);
                        }
                        else
                        {
                            //sw.WriteLine(parentItem.GetDirectory);
                            //sw.WriteLine(parentItem.EndDirectory);
                        }
                        
                    }
                }
                //foreach (var pathVariable in isPathVariableList)
                //{
                //    //var stringVariable = $"<String Id=\"{pathVariable.ISPathVariables}\">{pathVariable.Value}</String>";
                //    //sw.WriteLine(stringVariable);
                //}

                sw.Close();
            }
            if (tableName == "Component")
            {
                using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\components.txt");

                var reows = table.Elements("row");
                components = table.Descendants("row").Select(row =>
                new Component
                {
                    Components = row.Element("td")?.Value,
                    ComponentId = Guid.NewGuid().ToString(),
                    Directory_ = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Attributes = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Condition = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    KeyPath = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                    ISAttributes = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
                    ISScanAtBuildFile = row.Elements("td").Skip(7).FirstOrDefault()?.Value,
                    ISRegFileToMergeAtBuild = row.Elements("td").Skip(8).FirstOrDefault()?.Value,
                    ISDotNetInstallerArgsInstall = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISDotNetInstallerArgsCommit = row.Elements("td").Skip(10).FirstOrDefault()?.Value,
                    ISDotNetInstallerArgsUninstall = row.Elements("td").Skip(11).FirstOrDefault()?.Value,
                    ISDotNetInstallerArgsRollback = row.Elements("td").Skip(12).FirstOrDefault()?.Value,
                }).ToList();

                //foreach (var pathVariable in isPathVariableList)
                //{
                //    //var stringVariable = $"<String Id=\"{pathVariable.ISPathVariables}\">{pathVariable.Value}</String>";
                //    //sw.WriteLine(stringVariable);
                //}

                // sw.Close();
            }
            if (tableName == "File")
            {              

                var reows = table.Elements("row");
                files = table.Descendants("row").Select(row =>
                new File
                {
                    Files = row.Element("td")?.Value,
                    Component_ = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    FileName = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    FileSize = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Version = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Language = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                    Attributes = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
                    Sequence = row.Elements("td").Skip(7).FirstOrDefault()?.Value,
                    ISBuildSourcePath = row.Elements("td").Skip(8).FirstOrDefault()?.Value,
                    ISAttributes = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISComponentSubFolder_ = row.Elements("td").Skip(10).FirstOrDefault()?.Value,
                }).ToList();

                
            }

            if (tableName == "Registry")
            {
                var reows = table.Elements("row");
                registries = table.Descendants("row").Select(row =>
                new Registry
                {
                    Registrys = row.Element("td")?.Value,
                    Root = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    Key = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Name = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Value = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Component_ = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                    ISAttributes = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
                }).ToList();


            }
            if (tableName == "Dialog")
            {
                var reows = table.Elements("row");
                dialogs = table.Descendants("row").Select(row =>
                new Dialog
                {
                    Dialogs = row.Element("td")?.Value,
                    HCentering = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    VCentering = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Width = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Height = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Attributes = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                    Title = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
                    Control_First = row.Elements("td").Skip(7).FirstOrDefault()?.Value,
                    Control_Default = row.Elements("td").Skip(8).FirstOrDefault()?.Value,
                    Control_Cancel = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISComments = row.Elements("td").Skip(10).FirstOrDefault()?.Value,
                    TextStyle_ = row.Elements("td").Skip(11).FirstOrDefault()?.Value,
                    ISWindowStyle = row.Elements("td").Skip(12).FirstOrDefault()?.Value,
                    ISResourceId = row.Elements("td").Skip(13).FirstOrDefault()?.Value,
                }).ToList();


            }
            if (tableName == "Control")
            {
                var reows = table.Elements("row");
                controls = table.Descendants("row").Select(row =>
                new Control
                {
                    Dialog_ = row.Element("td")?.Value,
                    Controls = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    Type = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    X = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Y = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Width = row.Elements("td").Skip(5).FirstOrDefault()?.Value,
                    Height = row.Elements("td").Skip(6).FirstOrDefault()?.Value,
                    Attributes = row.Elements("td").Skip(7).FirstOrDefault()?.Value,
                    Property = row.Elements("td").Skip(8).FirstOrDefault()?.Value,
                    Text = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    Control_Next = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    Help = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISWindowStyle = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISControlId = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    ISBuildSourcePath = row.Elements("td").Skip(9).FirstOrDefault()?.Value,
                    Binary_ = row.Elements("td").Skip(9).FirstOrDefault()?.Value,

                }).ToList();


            }
            if (tableName == "ControlCondition")
            {
                var reows = table.Elements("row");
                controlConditions = table.Descendants("row").Select(row =>
                new ControlCondition
                {
                    Dialog_ = row.Element("td")?.Value,
                    Control_ = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    Action = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Condition = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                }).ToList();


            }
            if (tableName == "ControlEvent")
            {
                var reows = table.Elements("row");
                controlEvents = table.Descendants("row").Select(row =>
                new ControlEvent
                {
                    Dialog_ = row.Element("td")?.Value,
                    Control_ = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    Event = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    Argument = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Condition = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                }).ToList();


            }
            if (tableName == "Property")
            {
                using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\propes.txt");
                var reows = table.Elements("row");
                properties = table.Descendants("row").Select(row =>
                new Property
                {
                    Propertys = row.Element("td")?.Value,
                    Value = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    ISComments = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                }).ToList();
                foreach (var pathVariable in properties)
                {
                    var stringVariable = $"<Property Id=\"{pathVariable.Propertys}\"Value=\"{pathVariable.Value}\"/>";
                    sw.WriteLine(stringVariable);
                }

                sw.Close();

            }
            if (tableName == "RadioButton")
            {
                var reows = table.Elements("row");
                radioButtons = table.Descendants("row").Select(row =>
                new RadioButton
                {
                    Property = row.Element("td")?.Value,
                    Order = row.Elements("td").Skip(1).FirstOrDefault()?.Value,
                    Value = row.Elements("td").Skip(2).FirstOrDefault()?.Value,
                    X = row.Elements("td").Skip(3).FirstOrDefault()?.Value,
                    Y = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Width = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Height = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                    Text = row.Elements("td").Skip(4).FirstOrDefault()?.Value,
                }).ToList();


            }



            //sw.WriteLine("\t\t</UI>\r\n\t</Fragment>\r\n</Wix>");

            //}
            //sw.WriteLine("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/js/bootstrap.bundle.min.js\" integrity=\"sha384-C6RzsynM9kWDrMNeT87bh95OGNyZPhcTNXj1NW7RuBCsyN/o0jlpcV8Qyq46cDfL\" crossorigin=\"anonymous\"></script>\r\n</body>\r\n</html>");







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



            //String line;
            //string xmlStrisg = "E:\\Personal\\CSDRC\\Test.Wixtool\\PathVariables.wxl";
            //XDocument xDoc = XDocument.Load(xmlStrisg);
            //XNamespace nse = "http://schemas.microsoft.com/wix/2006/localization";

            //foreach (var element in xDoc.Descendants(nse + "String"))
            //{
            //    string id = element.Attribute("Id").Value;
            //    string pascalCase = ToPascalCase(id);
            //    string value = element.Value;
            //    //md.Add(new MasterD { Id = id, Value = value });
            //    Console.WriteLine($"Id: {id}, Value: {value}");
            //    element.SetAttributeValue("Id", pascalCase.Replace("_",""));

            //}
            //xDoc.Save("E:\\Personal\\CSDRC\\Test.Wixtool\\PathVariablesd.wxl");
            //try
            //{
            //    //Pass the file path and file name to the StreamReader constructor
            //   StreamReader sr = new StreamReader("C:\\Users\\Rajesh\\Documents\\stringMessaie.txt");
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
            //string directoryPath = "E:\\Personal\\CSDRC\\Test.Wixtool\\wix311-binaries";

            // PrintFilePaths(directoryPath);
            //Console.ReadLine();

        }

        //ProcessDLGWXSXml();
        ProcessDLGWXaSXml();
    }
    static void ProcessWXSXml()
    {
        using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\comsw.txt");
        using StreamWriter sw2 = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\comsws.txt");
        if (directories.Any())
        {
            foreach (var dir in directories)
            {
                var comps = components.Where(f => f.Directory_ == dir.Directorys);
                if (comps.Any())
                {
                    sw.WriteLine(dir.GetDirectoryRef);
                    foreach (var comp in comps)
                    {
                        sw.WriteLine(comp.GetComponent);
                        sw2.WriteLine(comp.GetComponentRef);
                        var registsries = registries.Where(h => h.Component_ == comp.Components);
                        if (registsries.Any())
                        {
                            foreach (var reg in registsries)
                            {
                                sw.WriteLine(reg.GetRegistry);
                            }
                        }
                        var fils = files.Where(g => g.Component_ == comp.Components);
                        if (fils.Any())
                        {
                            foreach (var fil in fils)
                            {
                                sw.WriteLine(fil.GetFile);
                            }
                        }
                        sw.WriteLine(comp.EndComponent);
                    }
                    sw.WriteLine(dir.EndDirectoryRef);
                }
            }
        }
        sw.Close();
        sw2.Close();
    }

    static void ProcessDLGWXSXml()
    {
        using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\DLG.txt");
        //using StreamWriter sw2 = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\comsws.txt");
        if (dialogs.Any())
        {
            foreach (var dlg in dialogs)
            {
                var ctrls = controls.Where(f => f.Dialog_ == dlg.Dialogs);
                if (ctrls.Any())
                {

                    sw.WriteLine($"<!-- Dialog:  {dlg.Dialogs} -->");
                    sw.WriteLine(dlg.GetDialog);
                    foreach (var ctrl in ctrls)
                    {
                        sw.WriteLine($"<!-- Control:  {ctrl.Controls} -->");
                        sw.WriteLine(ctrl.GetControl);
                        var registsries = controlEvents.Where(h => h.Control_ == ctrl.Controls && h.Dialog_ == dlg.Dialogs);
                        if (registsries.Any())
                        {
                            foreach (var reg in registsries)
                            {
                                sw.WriteLine($"<!-- Control Event:  {reg.Event} --> \r\n");
                                sw.WriteLine(reg.GetControlEvent);
                            }
                        }
                        var fils = controlConditions.Where(g => g.Control_ == ctrl.Controls && g.Dialog_ == dlg.Dialogs);
                        if (fils.Any())
                        {
                            foreach (var fil in fils)
                            {
                                sw.WriteLine($"<!-- Control Condition:  {fil.Action} --> \r\n");
                                sw.WriteLine($"<Condition Action=\"{fil.Action}\">\r\n<![CDATA[MyProperty = \"{fil.Condition}\"]]>\r\n</Condition>");
                            }
                        }
                        if (!string.IsNullOrEmpty(ctrl.Property))
                        {
                            var rads = radioButtons.Where(j => j.Property == ctrl.Property);
                            if (rads.Any())
                            {
                                sw.WriteLine($"<RadioButtonGroup Property=\"{ctrl.Property}\">");
                                foreach (var rad in rads)
                                {
                                    sw.WriteLine($"<!--Radio Button for Property :  {rad.Property} --> \r\n");
                                    sw.WriteLine($"<RadioButton Value=\"{rad.Value}\"\r\nText=\"{rad.Text}\"\r\nHeight=\"{rad.Height}\"\r\nWidth=\"{rad.Width}\"\r\nX=\"{rad.X}\"\r\nY=\"{rad.Y}\" />");
                                }
                                sw.WriteLine("</RadioButtonGroup>");
                            }
                            
                        }
                        
                        sw.WriteLine(ctrl.EndControl);
                    }
                    sw.WriteLine(dlg.EndDialog);
                }
            }
        }
        sw.Close();
        //sw2.Close();
    }
    static void ProcessDLGWXaSXml()
    {
        using StreamWriter sw = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\DLGa.txt");
        using StreamWriter sw2 = new StreamWriter("E:\\Personal\\CSDRC\\CSDRC.TestWix\\DLGs.txt");
        if (dialogs.Any())
        {
            foreach (var dlg in dialogs)
            {
                sw2.WriteLine($"<!-- DialogRef:{dlg.Dialogs}   --> \r\n");
                sw2.WriteLine($"<DialogRef Id=\"{dlg.Dialogs}Dlg\"/>");
                var registsries = controlEvents.Where(h =>  h.Dialog_ == dlg.Dialogs);
                if (registsries.Any())
                {
                    foreach (var reg in registsries)
                    {
                        var status = dialogs.Any(f => f.Dialogs.ToLower().Contains(reg.Argument.ToLower()));
                        var valuearg = status ? reg.Argument + "Dlg" : reg.Argument;
                        sw.WriteLine($"<!-- Control Event:{dlg.Dialogs}  {reg.Event} --> \r\n");
                        sw.WriteLine($"<Publish Dialog=\"{reg.Dialog_}Dlg\"\r\nControl=\"{reg.Control_}\"" +
                            $"\r\nEvent=\"{reg.Event}\"\r\nValue=\"{valuearg}\"><![CDATA[{reg.Condition}]]></Publish>");
                    }
                }
                //var ctrls = controls.Where(f => f.Dialog_ == dlg.Dialogs);
                //if (ctrls.Any())
                //{

                //    sw.WriteLine($"<!-- Dialog:  {dlg.Dialogs} -->");
                //    sw.WriteLine(dlg.GetDialog);
                //    foreach (var ctrl in ctrls)
                //    {
                //        sw.WriteLine($"<!-- Control:  {ctrl.Controls} -->");
                //        //sw.WriteLine(ctrl.GetControl);
                //        var registsries = controlEvents.Where(h => h.Control_ == ctrl.Controls && h.Dialog_ == dlg.Dialogs);
                //        if (registsries.Any())
                //        {
                //            foreach (var reg in registsries)
                //            {
                //                sw.WriteLine($"<!-- Control Event:  {reg.Event} --> \r\n");
                //                sw.WriteLine(reg.GetControlEvent);
                //            }
                //        }
                //        var fils = controlConditions.Where(g => g.Control_ == ctrl.Controls && g.Dialog_ == dlg.Dialogs);
                //        if (fils.Any())
                //        {
                //            foreach (var fil in fils)
                //            {
                //                sw.WriteLine($"<!-- Control Condition:  {fil.Action} --> \r\n");
                //                sw.WriteLine($"<Condition Action=\"{fil.Action}\">\r\n<![CDATA[MyProperty = \"{fil.Condition}\"]]>\r\n</Condition>");
                //            }
                //        }
                //        if (!string.IsNullOrEmpty(ctrl.Property))
                //        {
                //            var rads = radioButtons.Where(j => j.Property == ctrl.Property);
                //            if (rads.Any())
                //            {
                //                sw.WriteLine($"<RadioButtonGroup Property=\"{ctrl.Property}\">");
                //                foreach (var rad in rads)
                //                {
                //                    sw.WriteLine($"<!--Radio Button for Property :  {rad.Property} --> \r\n");
                //                    sw.WriteLine($"<RadioButton Value=\"{rad.Value}\"\r\nText=\"{rad.Text}\"\r\nHeight=\"{rad.Height}\"\r\nWidth=\"{rad.Width}\"\r\nX=\"{rad.X}\"\r\nY=\"{rad.Y}\" />");
                //                }
                //                sw.WriteLine("</RadioButtonGroup>");
                //            }

                //        }

                //        sw.WriteLine(ctrl.EndControl);
                //    }
                //    sw.WriteLine(dlg.EndDialog);
                //}
            }
        }
        sw.Close();
        sw2.Close();
    }
    static void AppendDlgToDialogIds(XDocument xDoc)
    {
        var dialogElements = xDoc.Descendants("{http://schemas.microsoft.com/wix/2006/wi}Dialog");

        StreamWriter sw = new StreamWriter("C:\\Users\\Rajesh\\Documents\\UIDLGREF.txt");
        // Iterate through each Dialog element
        foreach (var dialogElement in dialogElements)
        {
            // Get the existing Dialog Id attribute
            var dialogIdAttribute = dialogElement.Attribute("Id");

            // Check if the Dialog Id attribute exists
            if (dialogIdAttribute != null)
            {
                // Append "dlg" to the existing Dialog Id
                dialogIdAttribute.Value += "Dlg";
                sw.WriteLine($"<DialogRef Id=\"{dialogIdAttribute.Value}\"/>");
            }
        }
        sw.Close();
    }
    static void PrintFilePaths(string directory)
    {
        // Get all files in the directory and its subdirectories
        string[] files = System.IO.Directory.GetFiles(directory, "*", SearchOption.AllDirectories);
        StreamWriter sw = new StreamWriter("C:\\Users\\Rajesh\\Documents\\wixMessags.txt");

        // Print relative file paths
        foreach (string filePath in files)
        {
            string relativePath = GetRelativePath(filePath, directory);
            sw.WriteLine($"    - Source\\CSDRC.WixInstallerSetup\\CSDRC.WixInstallerSetup\\wix314-binaries\\{relativePath} -> .");
            Console.WriteLine(relativePath);
        }
        sw.Close();
    }

    static string GetRelativePath(string fullPath, string basePath)
    {
        return Path.GetRelativePath(basePath, fullPath);
    }
    static string ToPascalCase(string input)
    {
        TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
        return textInfo.ToTitleCase(input.ToLower());
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

    public class Column : ISPathVariable
    {

    }
}