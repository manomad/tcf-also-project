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
  public class TerminateAccountRequest {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Applicable only when terminating a service
    /// </summary>
    /// <value>Applicable only when terminating a service</value>
    [DataMember(Name="terminationReason", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "terminationReason")]
    public string TerminationReason { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class TerminateAccountRequest {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  TerminationReason: ").Append(TerminationReason).Append("\n");
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
