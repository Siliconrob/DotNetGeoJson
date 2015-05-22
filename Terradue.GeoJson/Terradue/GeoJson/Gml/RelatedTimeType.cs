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
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class RelatedTimeType : TimePrimitivePropertyType
  {
    private RelatedTimeTypeRelativePosition relativePositionField;
    private bool relativePositionFieldSpecified;

    [XmlAttribute]
    public RelatedTimeTypeRelativePosition relativePosition
    {
      get { return relativePositionField; }
      set { relativePositionField = value; }
    }

    [XmlIgnore]
    public bool relativePositionSpecified
    {
      get { return relativePositionFieldSpecified; }
      set { relativePositionFieldSpecified = value; }
    }
  }
}