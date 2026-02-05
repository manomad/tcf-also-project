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
  public class GetSubscriptionRequest {
    /// <summary>
    /// The subscription Account ID.
    /// </summary>
    /// <value>The subscription Account ID.</value>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account.
    /// </summary>
    /// <value>Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account.</value>
    [DataMember(Name="resellerContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resellerContext")]
    public int? ResellerContext { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSubscriptionRequest {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  ResellerContext: ").Append(ResellerContext).Append("\n");
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
