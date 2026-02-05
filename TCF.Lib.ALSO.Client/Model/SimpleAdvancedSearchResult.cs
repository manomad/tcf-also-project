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
  public class SimpleAdvancedSearchResult {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="AccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets AccountType
    /// </summary>
    [DataMember(Name="AccountType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AccountType")]
    public string AccountType { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets Field
    /// </summary>
    [DataMember(Name="Field", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Field")]
    public string Field { get; set; }

    /// <summary>
    /// Gets or Sets FieldValue
    /// </summary>
    [DataMember(Name="FieldValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldValue")]
    public string FieldValue { get; set; }

    /// <summary>
    /// Gets or Sets ProductName
    /// </summary>
    [DataMember(Name="ProductName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Gets or Sets ProductDisplayName
    /// </summary>
    [DataMember(Name="ProductDisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ProductDisplayName")]
    public string ProductDisplayName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class SimpleAdvancedSearchResult {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  AccountType: ").Append(AccountType).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  Field: ").Append(Field).Append("\n");
      sb.Append("  FieldValue: ").Append(FieldValue).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  ProductDisplayName: ").Append(ProductDisplayName).Append("\n");
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
