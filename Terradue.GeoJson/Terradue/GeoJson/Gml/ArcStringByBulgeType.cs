namespace Terradue.GeoJson.Gml
{
  [System.Xml.Serialization.XmlIncludeAttribute(typeof (ArcByBulgeType))]
  [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.1")]
  [System.SerializableAttribute()]
  [System.ComponentModel.DesignerCategoryAttribute("code")]
  [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengis.net/gml/3.2")]
  [System.Xml.Serialization.XmlRootAttribute("ArcStringByBulge", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public partial class ArcStringByBulgeType : AbstractCurveSegmentType
  {

    private object[] itemsField;

    private ItemsChoiceType3[] itemsElementNameField;

    private double[] bulgeField;

    private VectorType[] normalField;

    private CurveInterpolationType interpolationField;

    private bool interpolationFieldSpecified;

    private string numArcField;

    public ArcStringByBulgeType()
    {
      interpolationField = CurveInterpolationType.circularArc2PointWithBulge;
    }

    [System.Xml.Serialization.XmlElementAttribute("coordinates", typeof (CoordinatesType))]
    [System.Xml.Serialization.XmlElementAttribute("pointProperty", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pointRep", typeof (PointPropertyType))]
    [System.Xml.Serialization.XmlElementAttribute("pos", typeof (DirectPositionType))]
    [System.Xml.Serialization.XmlElementAttribute("posList", typeof (DirectPositionListType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType3[] ItemsElementName
    {
      get { return itemsElementNameField; }
      set { itemsElementNameField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("bulge")]
    public double[] bulge
    {
      get { return bulgeField; }
      set { bulgeField = value; }
    }

    [System.Xml.Serialization.XmlElementAttribute("normal")]
    public VectorType[] normal
    {
      get { return normalField; }
      set { normalField = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public CurveInterpolationType interpolation
    {
      get { return interpolationField; }
      set { interpolationField = value; }
    }

    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool interpolationSpecified
    {
      get { return interpolationFieldSpecified; }
      set { interpolationFieldSpecified = value; }
    }

    [System.Xml.Serialization.XmlAttributeAttribute(DataType = "integer")]
    public string numArc
    {
      get { return numArcField; }
      set { numArcField = value; }
    }
  }
}