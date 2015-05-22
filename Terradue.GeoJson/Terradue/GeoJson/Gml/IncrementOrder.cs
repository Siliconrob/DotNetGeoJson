using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [XmlType(Namespace = "http://www.opengis.net/gml/3.2")]
  public enum IncrementOrder
  {
    /// <remarks />
    [XmlEnum("+x+y")] xy,

    /// <remarks />
    [XmlEnum("+y+x")] yx,

    /// <remarks />
    [XmlEnum("+x-y")] xy1,

    /// <remarks />
    [XmlEnum("-x-y")] xy2
  }
}