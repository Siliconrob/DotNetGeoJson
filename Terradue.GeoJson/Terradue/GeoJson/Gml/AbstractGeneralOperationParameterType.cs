namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OperationParameterGroupType))]
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (OperationParameterType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("AbstractGeneralOperationParameter",
    Namespace = "http://www.opengis.net/gml/3.2", IsNullable = false)]
  public abstract partial class AbstractGeneralOperationParameterType : IdentifiedObjectType
  {

    private string minimumOccursField;

    [System.Xml.Serialization.XmlElementAttribute(DataType = "nonNegativeInteger")]
    public string minimumOccurs
    {
      get { return minimumOccursField; }
      set { minimumOccursField = value; }
    }
  }
}