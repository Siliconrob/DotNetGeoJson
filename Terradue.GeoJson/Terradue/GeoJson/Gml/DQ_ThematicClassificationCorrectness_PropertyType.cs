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
  public class DQ_ThematicClassificationCorrectness_PropertyType
  {
    private DQ_ThematicClassificationCorrectness_Type dQ_ThematicClassificationCorrectnessField;
    private string nilReasonField;
    private string uuidrefField;

    [XmlElement]
    public DQ_ThematicClassificationCorrectness_Type DQ_ThematicClassificationCorrectness
    {
      get { return dQ_ThematicClassificationCorrectnessField; }
      set { dQ_ThematicClassificationCorrectnessField = value; }
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