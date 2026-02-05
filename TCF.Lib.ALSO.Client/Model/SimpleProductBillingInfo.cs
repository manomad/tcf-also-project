using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// 
  /// </summary>
  [DataContract]
  public class SimpleProductBillingInfo {
    /// <summary>
    /// Billable Time Unit (Minute,Hour,Day,Month)
    /// </summary>
    /// <value>Billable Time Unit (Minute,Hour,Day,Month)</value>
    [DataMember(Name="BillableTimeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "BillableTimeUnit")]
    public string BillableTimeUnit { get; set; }

    /// <summary>
    /// Gets or Sets ChargeFirstTimeUnit
    /// </summary>
    [DataMember(Name="ChargeFirstTimeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeFirstTimeUnit")]
    public bool? ChargeFirstTimeUnit { get; set; }

    /// <summary>
    /// Gets or Sets ChargeLastTimeUnit
    /// </summary>
    [DataMember(Name="ChargeLastTimeUnit", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeLastTimeUnit")]
    public bool? ChargeLastTimeUnit { get; set; }

    /// <summary>
    /// Gets or Sets AdvancePaymentPeriodInMonths
    /// </summary>
    [DataMember(Name="AdvancePaymentPeriodInMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AdvancePaymentPeriodInMonths")]
    public decimal? AdvancePaymentPeriodInMonths { get; set; }

    /// <summary>
    /// Gets or Sets FieldDisplayName
    /// </summary>
    [DataMember(Name="FieldDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldDisplayName")]
    public string FieldDisplayName { get; set; }

    /// <summary>
    /// Gets or Sets FieldDisplayValue
    /// </summary>
    [DataMember(Name="FieldDisplayValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldDisplayValue")]
    public string FieldDisplayValue { get; set; }

    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="FieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Gets or Sets FieldValue
    /// </summary>
    [DataMember(Name="FieldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldValue")]
    public string FieldValue { get; set; }

    /// <summary>
    /// Gets or Sets VendorSku
    /// </summary>
    [DataMember(Name="VendorSku", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorSku")]
    public string VendorSku { get; set; }

    /// <summary>
    /// Gets or Sets MaterialNumber
    /// </summary>
    [DataMember(Name="MaterialNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaterialNumber")]
    public string MaterialNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleProductBillingInfo {\n");
      sb.Append("  BillableTimeUnit: ").Append(BillableTimeUnit).Append("\n");
      sb.Append("  ChargeFirstTimeUnit: ").Append(ChargeFirstTimeUnit).Append("\n");
      sb.Append("  ChargeLastTimeUnit: ").Append(ChargeLastTimeUnit).Append("\n");
      sb.Append("  AdvancePaymentPeriodInMonths: ").Append(AdvancePaymentPeriodInMonths).Append("\n");
      sb.Append("  FieldDisplayName: ").Append(FieldDisplayName).Append("\n");
      sb.Append("  FieldDisplayValue: ").Append(FieldDisplayValue).Append("\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
      sb.Append("  VendorSku: ").Append(VendorSku).Append("\n");
      sb.Append("  MaterialNumber: ").Append(MaterialNumber).Append("\n");
      sb.Append("}\n");
      return sb.ToString();
    }

    /// <summary>
    /// Get the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public string ToJson() {
      return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

}
}
