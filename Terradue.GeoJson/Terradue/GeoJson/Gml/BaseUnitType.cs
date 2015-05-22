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
  [XmlRoot("BaseUnit", Namespace = "http://www.opengis.net/gml/3.2",
    IsNullable = false)]
  public class BaseUnitType : UnitDefinitionType
  {
    private ReferenceType unitsSystemField;

    [XmlElement]
    public ReferenceType unitsSystem
    {
      get { return unitsSystemField; }
      set { unitsSystemField = value; }
    }
  }
}