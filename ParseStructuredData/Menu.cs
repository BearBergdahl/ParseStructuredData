
public class Menu
{
    public string Id { get; set; }
    public string Value { get; set; }
    
    public Popup Popup { get; set; }

}

public class Popup
{
    public List<MenuItem> MenuItems { get; set; }
}

public class MenuItem
{
    public string value { get; set; }
    public string OnClick { get; set; }
}
