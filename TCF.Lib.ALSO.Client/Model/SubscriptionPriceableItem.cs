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
  public class SubscriptionPriceableItem {
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
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="FieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Gets or Sets IsUDRCField
    /// </summary>
    [DataMember(Name="IsUDRCField", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsUDRCField")]
    public bool? IsUDRCField { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemDescription
    /// </summary>
    [DataMember(Name="PriceableItemDescription", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemDescription")]
    public string PriceableItemDescription { get; set; }

    /// <summary>
    /// Gets or Sets PriceableItemType
    /// </summary>
    [DataMember(Name="PriceableItemType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PriceableItemType")]
    public string PriceableItemType { get; set; }

    /// <summary>
    /// Gets or Sets PurchasePrice
    /// </summary>
    [DataMember(Name="PurchasePrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PurchasePrice")]
    public decimal? PurchasePrice { get; set; }

    /// <summary>
    /// Gets or Sets SalesPrice
    /// </summary>
    [DataMember(Name="SalesPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SalesPrice")]
    public decimal? SalesPrice { get; set; }

    /// <summary>
    /// Gets or Sets SuggestedRetailPrice
    /// </summary>
    [DataMember(Name="SuggestedRetailPrice", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "SuggestedRetailPrice")]
    public decimal? SuggestedRetailPrice { get; set; }

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
    /// Gets or Sets PrepaidPeriodInMonths
    /// </summary>
    [DataMember(Name="PrepaidPeriodInMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "PrepaidPeriodInMonths")]
    public decimal? PrepaidPeriodInMonths { get; set; }

    /// <summary>
    /// Gets or Sets CommitementPeriodInMonths
    /// </summary>
    [DataMember(Name="CommitementPeriodInMonths", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CommitementPeriodInMonths")]
    public decimal? CommitementPeriodInMonths { get; set; }

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
      sb.Append("class SubscriptionPriceableItem {\n");
      sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
      sb.Append("  Currency: ").Append(Currency).Append("\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  IsUDRCField: ").Append(IsUDRCField).Append("\n");
      sb.Append("  PriceableItemDescription: ").Append(PriceableItemDescription).Append("\n");
      sb.Append("  PriceableItemType: ").Append(PriceableItemType).Append("\n");
      sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
      sb.Append("  SalesPrice: ").Append(SalesPrice).Append("\n");
      sb.Append("  SuggestedRetailPrice: ").Append(SuggestedRetailPrice).Append("\n");
      sb.Append("  MaterialNumber: ").Append(MaterialNumber).Append("\n");
      sb.Append("  ProductNumber: ").Append(ProductNumber).Append("\n");
      sb.Append("  PrepaidPeriodInMonths: ").Append(PrepaidPeriodInMonths).Append("\n");
      sb.Append("  CommitementPeriodInMonths: ").Append(CommitementPeriodInMonths).Append("\n");
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
