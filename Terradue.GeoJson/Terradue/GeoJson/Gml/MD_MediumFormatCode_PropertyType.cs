namespace Terradue.GeoJson.Gml
{
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.isotc211.org/2005/gmd")]
  public partial class MD_MediumFormatCode_PropertyType
  {

    private CodeListValue_Type mD_MediumFormatCodeField;

    private string nilReasonField;

    [System.Xml.Serialization.XmlElementAttribute()]
    public CodeListValue_Type MD_MediumFormatCode
    {
      get { return mD_MediumFormatCodeField; }
      set { mD_MediumFormatCodeField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}