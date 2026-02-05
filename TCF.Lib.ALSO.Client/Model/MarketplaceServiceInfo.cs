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
  public class MarketplaceServiceInfo {
    /// <summary>
    /// Gets or Sets Charges
    /// </summary>
    [DataMember(Name="Charges", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Charges")]
    public List<MarketplaceServiceChargeInfo> Charges { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets ServiceId
    /// </summary>
    [DataMember(Name="ServiceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ServiceId")]
    public string ServiceId { get; set; }

    /// <summary>
    /// Gets or Sets MarketplaceId
    /// </summary>
    [DataMember(Name="MarketplaceId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MarketplaceId")]
    public int? MarketplaceId { get; set; }

    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [DataMember(Name="Status", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Status")]
    public string Status { get; set; }

    /// <summary>
    /// Gets or Sets VendorDisplayName
    /// </summary>
    [DataMember(Name="VendorDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "VendorDisplayName")]
    public string VendorDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketplaceServiceInfo {\n");
      sb.Append("  Charges: ").Append(Charges).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
      sb.Append("  MarketplaceId: ").Append(MarketplaceId).Append("\n");
      sb.Append("  Status: ").Append(Status).Append("\n");
      sb.Append("  VendorDisplayName: ").Append(VendorDisplayName).Append("\n");
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
