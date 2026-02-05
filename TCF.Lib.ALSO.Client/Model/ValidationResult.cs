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
  public class ValidationResult {
    /// <summary>
    /// Gets or Sets Result
    /// </summary>
    [DataMember(Name="Result", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "Result")]
    public string Result { get; set; }

    /// <summary>
    /// Gets or Sets ErrorDetails
    /// </summary>
    [DataMember(Name="ErrorDetails", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "ErrorDetails")]
    public string ErrorDetails { get; set; }

    /// <summary>
    /// Gets or Sets FieldName
    /// </summary>
    [DataMember(Name="FieldName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldName")]
    public string FieldName { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValidationResult {\n");
      sb.Append("  Result: ").Append(Result).Append("\n");
      sb.Append("  ErrorDetails: ").Append(ErrorDetails).Append("\n");
      sb.Append("  FieldName: ").Append(FieldName).Append("\n");
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
