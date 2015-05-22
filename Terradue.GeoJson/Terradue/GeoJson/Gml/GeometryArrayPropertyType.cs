using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot("geometryMembers", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class GeometryArrayPropertyType
  {
    private GeometricComplexType[] itemsField;
    private bool ownsField;

    public GeometryArrayPropertyType()
    {
      ownsField = false;
    }

    [XmlElement("GeometricComplex")]
    public GeometricComplexType[] Items
    {
      get { return itemsField; }
      set { itemsField = value; }
    }

    [XmlAttribute]
    [DefaultValue(false)]
    public bool owns
    {
      get { return ownsField; }
      set { ownsField = value; }
    }
  }
}