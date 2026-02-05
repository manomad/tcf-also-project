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
  public class ConfigureSubscriptionRenewRequest {
    /// <summary>
    /// Account id of the account which should be upgraded.
    /// </summary>
    /// <value>Account id of the account which should be upgraded.</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public int? AccountId { get; set; }

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
      sb.Append("class ConfigureSubscriptionRenewRequest {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
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
