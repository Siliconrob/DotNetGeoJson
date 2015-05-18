namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("priorityLocation", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class PriorityLocationPropertyType : LocationPropertyType
  {

    private string priorityField;

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string priority
    {
      get { return priorityField; }
      set { priorityField = value; }
    }
  }
}