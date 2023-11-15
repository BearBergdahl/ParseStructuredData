
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class Choice
{
    public string id { get; set; }

    public string value {  get; set; }

    public ChoicePopup popup {  get; set; }

}

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ChoicePopup
{

    [System.Xml.Serialization.XmlArrayItemAttribute("item", IsNullable = false)]
    public ChoicePopupItem[] menuitems {  get; set; }

}

[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ChoicePopupItem
{
    public string value { get; set; }

    public string onclick{ get; set; }
}

