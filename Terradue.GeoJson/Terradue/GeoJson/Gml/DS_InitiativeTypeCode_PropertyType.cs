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
  public class DS_InitiativeTypeCode_PropertyType
  {
    private CodeListValue_Type dS_InitiativeTypeCodeField;
    private string nilReasonField;

    [XmlElement]
    public CodeListValue_Type DS_InitiativeTypeCode
    {
      get { return dS_InitiativeTypeCodeField; }
      set { dS_InitiativeTypeCodeField = value; }
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