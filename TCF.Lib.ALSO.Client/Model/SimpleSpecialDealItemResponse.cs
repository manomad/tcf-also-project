using System;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace IO.Swagger.Model {

  /// <summary>
  /// If IsCustomCharge is false, the Discount (%) is applied and CustomCharge is ignored. If IsCustomCharge is true, the CustomCharge amount is applied and the Discount (%) is ignored.
  /// </summary>
  [DataContract]
  public class SimpleSpecialDealItemResponse {
    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets CustomCharge
    /// </summary>
    [DataMember(Name="CustomCharge", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomCharge")]
    public decimal? CustomCharge { get; set; }

    /// <summary>
    /// Gets or Sets Discount
    /// </summary>
    [DataMember(Name="Discount", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Discount")]
    public decimal? Discount { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemId
    /// </summary>
    [DataMember(Name="PriceableItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemId")]
    public int? PriceableItemId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleSpecialDealItemResponse {\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  CustomCharge: ").Append(CustomCharge).Append("\n");
      sb.Append("  Discount: ").Append(Discount).Append("\n");
      sb.Append("  PriceableItemId: ").Append(PriceableItemId).Append("\n");
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
