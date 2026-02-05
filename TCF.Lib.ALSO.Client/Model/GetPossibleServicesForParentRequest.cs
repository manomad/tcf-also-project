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
  public class GetPossibleServicesForParentRequest {
    /// <summary>
    /// Parent subscription account id. I.e. account id of the company account under which you wish to add new subscription.
    /// </summary>
    /// <value>Parent subscription account id. I.e. account id of the company account under which you wish to add new subscription.</value>
    [DataMember(Name="parentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentAccountId")]
    public int? ParentAccountId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetPossibleServicesForParentRequest {\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
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
