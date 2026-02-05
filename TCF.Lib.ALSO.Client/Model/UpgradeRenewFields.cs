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
  public class UpgradeRenewFields {
    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name="DisplayName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayName")]
    public string DisplayName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayTemplate
    /// </summary>
    [DataMember(Name="DisplayTemplate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayTemplate")]
    public string DisplayTemplate { get; set; }

    /// <summary>
    /// Gets or Sets DisplayType
    /// </summary>
    [DataMember(Name="DisplayType", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DisplayType")]
    public string DisplayType { get; set; }

    /// <summary>
    /// Gets or Sets IsRemoteDatasource
    /// </summary>
    [DataMember(Name="IsRemoteDatasource", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRemoteDatasource")]
    public bool? IsRemoteDatasource { get; set; }

    /// <summary>
    /// Gets or Sets Hint
    /// </summary>
    [DataMember(Name="Hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hint")]
    public string Hint { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name="Value", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Value")]
    public Object Value { get; set; }

    /// <summary>
    /// Gets or Sets AllowedValues
    /// </summary>
    [DataMember(Name="AllowedValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "AllowedValues")]
    public List<EnumValues> AllowedValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class UpgradeRenewFields {\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DisplayTemplate: ").Append(DisplayTemplate).Append("\n");
      sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
      sb.Append("  IsRemoteDatasource: ").Append(IsRemoteDatasource).Append("\n");
      sb.Append("  Hint: ").Append(Hint).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Value: ").Append(Value).Append("\n");
      sb.Append("  AllowedValues: ").Append(AllowedValues).Append("\n");
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
