using Newtonsoft.Json;
using System.Text.Json;
using System.Xml.Serialization;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Choice xmlChoice = XMLParserMethod();
        Menu jsonMenu = JSONParserMethod();

        Menu newMenu = new Menu
        {
            Id = "file",
            Value = "File",
            Popup = new Popup
            {
                MenuItems = new List<MenuItem> {
                    new MenuItem { value = "New", OnClick = "CreateNewDoc()" },
                    new MenuItem { value = "Open", OnClick = "OpenDoc()" },
                    new MenuItem { value = "Close", OnClick = "CloseDoc()" }
                }
            }
        };

        if (xmlChoice.value == jsonMenu.Value && xmlChoice.popup.menuitems[1].value == newMenu.Popup.MenuItems[1].value)
        {
            Console.WriteLine("Success");
        }        
    }

    private static Menu JSONParserMethod()
    {
        string path = "D:\\repos\\ParseStructuredData\\ParseStructuredData\\FileResource\\Example1.json";
        string jsonFile= ReadFile(path);
        var serializer = new Newtonsoft.Json.JsonSerializer();
        Menu jsonMenu = JsonConvert.DeserializeObject<Menu>(jsonFile);
           
        return jsonMenu;
    }

    private static Choice XMLParserMethod()
    {
        string path = "D:\\repos\\ParseStructuredData\\ParseStructuredData\\FileResource\\Example1.xml";
        Choice choice = FromXml<Choice>(ReadFile(path));
        return choice;
    }

    private static string ReadFile(string path)
    {
        string returnedfile = System.IO.File.ReadAllText(path);
        return returnedfile;
    }
    protected static T FromXml<T>(String xml)
    {
        T returnedXmlClass = default(T);

        try
        {
            using (TextReader reader = new StringReader(xml))
            {
                try
                {
                    returnedXmlClass =
                        (T)new XmlSerializer(typeof(T)).Deserialize(reader);
                }
                catch (InvalidOperationException)
                {
                    //return some empty class
                }
            }
        }
        catch (Exception ex)
        {
        }

        return returnedXmlClass;
    }
}