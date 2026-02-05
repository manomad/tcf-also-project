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
  public class ExecuteProductUpgradeRequest {
    /// <summary>
    /// Account id of the account which should be upgraded.
    /// </summary>
    /// <value>Account id of the account which should be upgraded.</value>
    [DataMember(Name="sourceAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "sourceAccountId")]
    public int? SourceAccountId { get; set; }

    /// <summary>
    /// Technical product name of destination account
    /// </summary>
    /// <value>Technical product name of destination account</value>
    [DataMember(Name="targetProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetProductName")]
    public string TargetProductName { get; set; }

    /// <summary>
    /// Gets or Sets TargetAccountId
    /// </summary>
    [DataMember(Name="targetAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "targetAccountId")]
    public int? TargetAccountId { get; set; }

    /// <summary>
    /// Gets or Sets FieldValues
    /// </summary>
    [DataMember(Name="fieldValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldValues")]
    public ExecuteProductUpgradeRequestFieldValues FieldValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExecuteProductUpgradeRequest {\n");
      sb.Append("  SourceAccountId: ").Append(SourceAccountId).Append("\n");
      sb.Append("  TargetProductName: ").Append(TargetProductName).Append("\n");
      sb.Append("  TargetAccountId: ").Append(TargetAccountId).Append("\n");
      sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
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
