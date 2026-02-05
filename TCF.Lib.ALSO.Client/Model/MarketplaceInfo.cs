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
  public class MarketplaceInfo {
    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name="Id", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets ServiceCount
    /// </summary>
    [DataMember(Name="ServiceCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceCount")]
    public int? ServiceCount { get; set; }

    /// <summary>
    /// Gets or Sets HiddenServiceCount
    /// </summary>
    [DataMember(Name="HiddenServiceCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "HiddenServiceCount")]
    public int? HiddenServiceCount { get; set; }

    /// <summary>
    /// Gets or Sets AssigneeCount
    /// </summary>
    [DataMember(Name="AssigneeCount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AssigneeCount")]
    public int? AssigneeCount { get; set; }

    /// <summary>
    /// Gets or Sets Priority
    /// </summary>
    [DataMember(Name="Priority", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Priority")]
    public int? Priority { get; set; }

    /// <summary>
    /// Gets or Sets PricingMode
    /// </summary>
    [DataMember(Name="PricingMode", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PricingMode")]
    public string PricingMode { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketplaceInfo {\n");
      sb.Append("  Id: ").Append(Id).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  ServiceCount: ").Append(ServiceCount).Append("\n");
      sb.Append("  HiddenServiceCount: ").Append(HiddenServiceCount).Append("\n");
      sb.Append("  AssigneeCount: ").Append(AssigneeCount).Append("\n");
      sb.Append("  Priority: ").Append(Priority).Append("\n");
      sb.Append("  PricingMode: ").Append(PricingMode).Append("\n");
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
