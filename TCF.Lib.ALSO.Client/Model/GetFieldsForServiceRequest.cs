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
  public class GetFieldsForServiceRequest {
    /// <summary>
    /// Account id of the account under which to add the new service. This is necessary since we calculate things like available enum values and default values based on the parent.
    /// </summary>
    /// <value>Account id of the account under which to add the new service. This is necessary since we calculate things like available enum values and default values based on the parent.</value>
    [DataMember(Name="parentAccountId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "parentAccountId")]
    public int? ParentAccountId { get; set; }

    /// <summary>
    /// Internal name of the service to add.
    /// </summary>
    /// <value>Internal name of the service to add.</value>
    [DataMember(Name="productName", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "productName")]
    public string ProductName { get; set; }

    /// <summary>
    /// Optional. Some services require secondary parent subscription - I.e. MS Office Subscriptions require MS Tenant subscription as a secondary parent. This is also required (when applicable) to calculate enums and default values.
    /// </summary>
    /// <value>Optional. Some services require secondary parent subscription - I.e. MS Office Subscriptions require MS Tenant subscription as a secondary parent. This is also required (when applicable) to calculate enums and default values.</value>
    [DataMember(Name="secondaryParentId", EmitDefaultValue=false)]
    [JsonProperty(PropertyName = "secondaryParentId")]
    public int? SecondaryParentId { get; set; }


    /// <summary>
    /// Get the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()  {
      var sb = new StringBuilder();
      sb.Append("class GetFieldsForServiceRequest {\n");
      sb.Append("  ParentAccountId: ").Append(ParentAccountId).Append("\n");
      sb.Append("  ProductName: ").Append(ProductName).Append("\n");
      sb.Append("  SecondaryParentId: ").Append(SecondaryParentId).Append("\n");
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
