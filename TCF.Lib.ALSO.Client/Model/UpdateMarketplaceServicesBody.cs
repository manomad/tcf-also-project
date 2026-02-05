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
  public class UpdateMarketplaceServicesBody {
    /// <summary>
    /// Gets or Sets MarketplaceOfferId
    /// </summary>
    [DataMember(Name="marketplaceOfferId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "marketplaceOfferId")]
    public int? MarketplaceOfferId { get; set; }

    /// <summary>
    /// Gets or Sets Services
    /// </summary>
    [DataMember(Name="services", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "services")]
    public List<MarketplaceServiceInfo> Services { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpdateMarketplaceServicesBody {\n");
      sb.Append("  MarketplaceOfferId: ").Append(MarketplaceOfferId).Append("\n");
      sb.Append("  Services: ").Append(Services).Append("\n");
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
