using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Terradue.GeoJson.Gml
{
  [GeneratedCode("System.Xml", "4.0.30319.1")]
  [Serializable]
  [DesignerCategory("code")]
  [XmlType(Namespace = "http://www.isotc211.org/2005/gts")]
  public class TM_Primitive_PropertyType
  {
    private AbstractTimePrimitiveType abstractTimePrimitiveField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement(Namespace = "http://www.opengis.net/gml/3.2")]
    public AbstractTimePrimitiveType AbstractTimePrimitive
    {
      get { return abstractTimePrimitiveField; }
      set { abstractTimePrimitiveField = value; }
    }

    [XmlAttribute]
    public string uuidref
    {
      get { return uuidrefField; }
      set { uuidrefField = value; }
    }

    [XmlAttribute(Form = XmlSchemaForm.Qualified,
      Namespace = "http://www.isotc211.org/2005/gco")]
    public string nilReason
    {
      get { return nilReasonField; }
      set { nilReasonField = value; }
    }
  }
}