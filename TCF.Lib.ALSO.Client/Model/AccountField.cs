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
  public class AccountField {
    /// <summary>
    /// Gets or Sets DefaultValue
    /// </summary>
    [DataMember(Name="DefaultValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "DefaultValue")]
    public AccountFieldValue DefaultValue { get; set; }

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
    /// Gets or Sets EnumMembers
    /// </summary>
    [DataMember(Name="EnumMembers", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "EnumMembers")]
    public List<AccountFieldValueItem> EnumMembers { get; set; }

    /// <summary>
    /// Gets or Sets Hint
    /// </summary>
    [DataMember(Name="Hint", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Hint")]
    public string Hint { get; set; }

    /// <summary>
    /// Gets or Sets IsList
    /// </summary>
    [DataMember(Name="IsList", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsList")]
    public bool? IsList { get; set; }

    /// <summary>
    /// Gets or Sets IsPartialValidation
    /// </summary>
    [DataMember(Name="IsPartialValidation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsPartialValidation")]
    public bool? IsPartialValidation { get; set; }

    /// <summary>
    /// Gets or Sets IsRemoteValidation
    /// </summary>
    [DataMember(Name="IsRemoteValidation", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsRemoteValidation")]
    public bool? IsRemoteValidation { get; set; }

    /// <summary>
    /// Gets or Sets IsUnique
    /// </summary>
    [DataMember(Name="IsUnique", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "IsUnique")]
    public bool? IsUnique { get; set; }

    /// <summary>
    /// Gets or Sets MaxValue
    /// </summary>
    [DataMember(Name="MaxValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MaxValue")]
    public Object MaxValue { get; set; }

    /// <summary>
    /// Gets or Sets MinValue
    /// </summary>
    [DataMember(Name="MinValue", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "MinValue")]
    public Object MinValue { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name="Name", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Name")]
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name="Type", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Type")]
    public string Type { get; set; }

    /// <summary>
    /// A regexp that should be used to validate input in this field.
    /// </summary>
    /// <value>A regexp that should be used to validate input in this field.</value>
    [DataMember(Name="Validator", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Validator")]
    public string Validator { get; set; }

    /// <summary>
    /// An array of custom properties with key value
    /// </summary>
    /// <value>An array of custom properties with key value</value>
    [DataMember(Name="CustomProperties", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "CustomProperties")]
    public Object CustomProperties { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class AccountField {\n");
      sb.Append("  DefaultValue: ").Append(DefaultValue).Append("\n");
      sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
      sb.Append("  DisplayTemplate: ").Append(DisplayTemplate).Append("\n");
      sb.Append("  DisplayType: ").Append(DisplayType).Append("\n");
      sb.Append("  EnumMembers: ").Append(EnumMembers).Append("\n");
      sb.Append("  Hint: ").Append(Hint).Append("\n");
      sb.Append("  IsList: ").Append(IsList).Append("\n");
      sb.Append("  IsPartialValidation: ").Append(IsPartialValidation).Append("\n");
      sb.Append("  IsRemoteValidation: ").Append(IsRemoteValidation).Append("\n");
      sb.Append("  IsUnique: ").Append(IsUnique).Append("\n");
      sb.Append("  MaxValue: ").Append(MaxValue).Append("\n");
      sb.Append("  MinValue: ").Append(MinValue).Append("\n");
      sb.Append("  Name: ").Append(Name).Append("\n");
      sb.Append("  Type: ").Append(Type).Append("\n");
      sb.Append("  Validator: ").Append(Validator).Append("\n");
      sb.Append("  CustomProperties: ").Append(CustomProperties).Append("\n");
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
