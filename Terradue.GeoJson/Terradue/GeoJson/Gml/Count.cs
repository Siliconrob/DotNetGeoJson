using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(AnonymousType = true, Namespace = "http://www.opengis.net/gml/3.2")]
  [XmlRoot(Namespace = "http://www.opengis.net/gml/3.2", IsNullable = true)]
  public class Count
  {
    private string nilReasonField;
    private string valueField;

    [XmlAttribute]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }

    [XmlText(DataType = "integer")]
    public string Value
    {
      get { return valueField; }
      set { valueField = value; }
    }
  }
}