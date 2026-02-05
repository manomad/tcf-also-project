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
  public class GetRemoteEnumValuesForCustomActionBody {
    /// <summary>
    /// Gets or Sets AccountId
    /// </summary>
    [DataMember(Name="accountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "accountId")]
    public int? AccountId { get; set; }

    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [DataMember(Name="action", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "action")]
    public string Action { get; set; }

    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="fieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldName")]
    public string FieldName { get; set; }

    /// <summary>
    /// Gets or Sets FieldValues
    /// </summary>
    [DataMember(Name="fieldValues", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "fieldValues")]
    public Dictionary<string, Object> FieldValues { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetRemoteEnumValuesForCustomActionBody {\n");
      sb.Append("  AccountId: ").Append(AccountId).Append("\n");
      sb.Append("  Action: ").Append(Action).Append("\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
      sb.Append("  FieldValues: ").Append(FieldValues).Append("\n");
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
