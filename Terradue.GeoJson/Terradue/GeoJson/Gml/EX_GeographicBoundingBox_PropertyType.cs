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
  [XmlType(Namespace = "http://www.isotc211.org/2005/gmd")]
  public class EX_GeographicBoundingBox_PropertyType
  {
    private EX_GeographicBoundingBox_Type eX_GeographicBoundingBoxField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public EX_GeographicBoundingBox_Type EX_GeographicBoundingBox
    {
      get { return eX_GeographicBoundingBoxField; }
      set { eX_GeographicBoundingBoxField = value; }
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