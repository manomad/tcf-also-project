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
  public class ExecuteAccountCustomActionRequestSubscriptionAccount {
    /// <summary>
    /// Provide only for ValidateFields methode when modifying subscription
    /// </summary>
    /// <value>Provide only for ValidateFields methode when modifying subscription</value>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets Fields
    /// </summary>
    [DataMember(Name="Fields", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Fields")]
    public SubscriptionAccountSubscriptionAccountFields Fields { get; set; }

    /// <summary>
    /// Gets or Sets ServiceName
    /// </summary>
    [DataMember(Name="ServiceName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceName")]
    public string ServiceName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ExecuteAccountCustomActionRequestSubscriptionAccount {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Fields: ").Append(Fields).Append("\n");
      sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
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
