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
  public class GetSubscriptionsRequest {
    /// <summary>
    /// The parent Account ID.
    /// </summary>
    /// <value>The parent Account ID.</value>
    [DataMember(Name="parentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account.\"
    /// </summary>
    /// <value>Should be removed from payload if not used.The reseller context Account ID. Used to determine subscription priceable items purchase price. This parameter is optional, if not set, default value is set to method callers reseller account.\"</value>
    [DataMember(Name="resellerContext", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "resellerContext")]
    public int? ResellerContext { get; set; }

    /// <summary>
    /// If set to true then user level subscriptions are excluded from result. If not set then all subscriptions are returned.
    /// </summary>
    /// <value>If set to true then user level subscriptions are excluded from result. If not set then all subscriptions are returned.</value>
    [DataMember(Name="excludeUserLevel", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "excludeUserLevel")]
    public bool? ExcludeUserLevel { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetSubscriptionsRequest {\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  ResellerContext: ").Append(ResellerContext).Append("\n");
      sb.Append("  ExcludeUserLevel: ").Append(ExcludeUserLevel).Append("\n");
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
