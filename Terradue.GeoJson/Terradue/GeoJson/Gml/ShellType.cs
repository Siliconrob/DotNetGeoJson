namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("Shell", Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public partial class ShellType
  {

    private SurfacePropertyType[] surfaceMemberField;

    private AggregationType aggregationTypeField;

    private bool aggregationTypeFieldSpecified;

    [System.Xml.Serialization.XmlElementAttribute("surfaceMember")]
    public SurfacePropertyType[] surfaceMember
    {
      get { return surfaceMemberField; }
      set { surfaceMemberField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public AggregationType aggregationType
    {
      get { return aggregationTypeField; }
      set { aggregationTypeField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool aggregationTypeSpecified
    {
      get { return aggregationTypeFieldSpecified; }
      set { aggregationTypeFieldSpecified = value; }
    }
  }
}