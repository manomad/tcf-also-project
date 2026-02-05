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
  public class ValidateFieldsSubscriptionAccount {
    /// <summary>
    /// A list of field names to validate. If nothing provided, all fields with validation will be validated
    /// </summary>
    /// <value>A list of field names to validate. If nothing provided, all fields with validation will be validated</value>
    [DataMember(Name="FieldsToValidate", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "FieldsToValidate")]
    public List<string> FieldsToValidate { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class ValidateFieldsSubscriptionAccount {\n");
      sb.Append("  FieldsToValidate: ").Append(FieldsToValidate).Append("\n");
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
