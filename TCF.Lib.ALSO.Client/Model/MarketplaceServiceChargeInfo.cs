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
  public class MarketplaceServiceChargeInfo {
    /// <summary>
    /// Gets or Sets PriceableItemId
    /// </summary>
    [DataMember(Name="PriceableItemId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemId")]
    public int? PriceableItemId { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItem
    /// </summary>
    [DataMember(Name="PriceableItem", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItem")]
    public string PriceableItem { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemType
    /// </summary>
    [DataMember(Name="PriceableItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemType")]
    public string PriceableItemType { get; set; }

    /// <summary>
    /// Gets or Sets ChargeType
    /// </summary>
    [DataMember(Name="ChargeType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ChargeType")]
    public string ChargeType { get; set; }

    /// <summary>
    /// Gets or Sets Currency
    /// </summary>
    [DataMember(Name="Currency", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Currency")]
    public string Currency { get; set; }

    /// <summary>
    /// Gets or Sets PurchasePrice
    /// </summary>
    [DataMember(Name="PurchasePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchasePrice")]
    public decimal? PurchasePrice { get; set; }

    /// <summary>
    /// Gets or Sets SuggestedRetailPrice
    /// </summary>
    [DataMember(Name="SuggestedRetailPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SuggestedRetailPrice")]
    public decimal? SuggestedRetailPrice { get; set; }

    /// <summary>
    /// Gets or Sets CustomPrice
    /// </summary>
    [DataMember(Name="CustomPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomPrice")]
    public decimal? CustomPrice { get; set; }

    /// <summary>
    /// Gets or Sets PreviousCustomPrice
    /// </summary>
    [DataMember(Name="PreviousCustomPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PreviousCustomPrice")]
    public decimal? PreviousCustomPrice { get; set; }

    /// <summary>
    /// Gets or Sets MaterialNumber
    /// </summary>
    [DataMember(Name="MaterialNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaterialNumber")]
    public string MaterialNumber { get; set; }

    /// <summary>
    /// Gets or Sets ProductNumber
    /// </summary>
    [DataMember(Name="ProductNumber", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductNumber")]
    public string ProductNumber { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class MarketplaceServiceChargeInfo {\n");
      sb.Append("  PriceableItemId: ").Append(PriceableItemId).Append("\n");
      sb.Append("  PriceableItem: ").Append(PriceableItem).Append("\n");
      sb.Append("  PriceableItemType: ").Append(PriceableItemType).Append("\n");
      sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
      sb.Append("  SuggestedRetailPrice: ").Append(SuggestedRetailPrice).Append("\n");
      sb.Append("  CustomPrice: ").Append(CustomPrice).Append("\n");
      sb.Append("  PreviousCustomPrice: ").Append(PreviousCustomPrice).Append("\n");
      sb.Append("  MaterialNumber: ").Append(MaterialNumber).Append("\n");
      sb.Append("  ProductNumber: ").Append(ProductNumber).Append("\n");
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
