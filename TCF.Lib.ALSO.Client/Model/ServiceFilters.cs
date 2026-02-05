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
  public class ServiceFilters {
    /// <summary>
    /// Gets or Sets OwnerAccountIds
    /// </summary>
    [DataMember(Name="OwnerAccountIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "OwnerAccountIds")]
    public List<int?> OwnerAccountIds { get; set; }

    /// <summary>
    /// Gets or Sets ServiceCategories
    /// </summary>
    [DataMember(Name="ServiceCategories", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceCategories")]
    public List<string> ServiceCategories { get; set; }

    /// <summary>
    /// Gets or Sets ServiceTags
    /// </summary>
    [DataMember(Name="ServiceTags", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceTags")]
    public List<string> ServiceTags { get; set; }

    /// <summary>
    /// Gets or Sets ServiceGroups
    /// </summary>
    [DataMember(Name="ServiceGroups", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceGroups")]
    public List<string> ServiceGroups { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemIds
    /// </summary>
    [DataMember(Name="PriceableItemIds", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemIds")]
    public List<int?> PriceableItemIds { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ServiceFilters {\n");
      sb.Append("  OwnerAccountIds: ").Append(OwnerAccountIds).Append("\n");
      sb.Append("  ServiceCategories: ").Append(ServiceCategories).Append("\n");
      sb.Append("  ServiceTags: ").Append(ServiceTags).Append("\n");
      sb.Append("  ServiceGroups: ").Append(ServiceGroups).Append("\n");
      sb.Append("  PriceableItemIds: ").Append(PriceableItemIds).Append("\n");
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
