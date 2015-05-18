namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("projectedCRSRef", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ProjectedCRSPropertyType
  {

    private ProjectedCRSType projectedCRSField;

    private string nilReasonField;

    private string remoteSchemaField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public ProjectedCRSType ProjectedCRS
    {
      get { return projectedCRSField; }
      set { projectedCRSField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      DataType = "anyURI")]
    public string remoteSchema
    {
      get { return remoteSchemaField; }
      set { remoteSchemaField = value; }
    }
  }
}